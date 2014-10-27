using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using IMDb_Rating_App.Model;
using System.Globalization;
using System.Diagnostics;
using System.IO;
using IMDb_Rating_App.Proxy;
using IMDb_Rating_App.Forms;

namespace IMDb_Rating_App
{
    public partial class MainForm : Form
    {

        private IMDbTitle currentTitle { get; set; }
        private int count { get; set; }
        private int total { get; set; }
        private List<TitleGroup> titleGroups { get; set; }
        private DateTime startTime { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void searchClick(object sender, EventArgs e)
        {
            statusLb.Text = "Loading...";
            searchBtn.Enabled = false;
            removeCurrentGroups();

            imdbRb.Visible = false;
            imdbRb.Checked = true;
            metascoreRb.Visible = false;

            progress.Visible = true;
            progress.Value = 0;

            bgWorker.RunWorkerAsync();
        }

        private void removeCurrentGroups()
        {
            if (titleGroups != null)
                foreach (TitleGroup titleGroup in titleGroups)
                    panel1.Controls.Remove(titleGroup.Group);

            titleGroups = new List<TitleGroup>();
        }

        private void addTitle(IMDbTitle title, int counter)
        {
            GroupBox group = new GroupBox()
            {
                Text = TemplateGb.Text,
                Anchor = TemplateGb.Anchor,
                Size = TemplateGb.Size
            };

            PictureBox poster = new PictureBox()
            {
                Location = posterPb.Location,
                Size = posterPb.Size,
                SizeMode = posterPb.SizeMode,
                Cursor = posterPb.Cursor
            };

            if (!string.IsNullOrEmpty(title.Poster))
                poster.Load(title.Poster);

            poster.Click += new EventHandler(posterPb_Click);

            Label movieTitle = new Label()
            {
                Location = titleLb.Location,
                AutoSize = true,
                Font = titleLb.Font,
                Cursor = titleLb.Cursor,
                Text = title.Title + " (" + title.Year + ")"
            };
           
            movieTitle.Click += new EventHandler(movieTitle_Click);

            Label rating = new Label()
            {
                Location = ratingLb.Location,
                AutoSize = true,
                Font = ratingLb.Font,
                Text = title.Rating.ToString("F2", CultureInfo.GetCultureInfo("en-GB")) + " IMDb rating",
                BackColor = ratingLb.BackColor,
                Padding = ratingLb.Padding
            };

            string metascoreText = "No Metascore";
            Color metascoreBackground = Color.FromArgb(255, 204, 51);

            if (title.Metascore > 0)
                metascoreText = title.Metascore.ToString() + " Metascore";

            if (title.Metascore > 0 && title.Metascore < 40)
                metascoreBackground = Color.FromArgb(255, 0, 0);
            else if (title.Metascore >= 60)
                metascoreBackground = Color.FromArgb(102, 204, 51);

            Label metascore = new Label()
            {
                AutoSize = true,
                Font = metascoreLb.Font,
                Text = metascoreText,
                BackColor = metascoreBackground,
                ForeColor = metascoreLb.ForeColor,
                Padding = metascoreLb.Padding
            };

            Label genres = new Label()
            {
                Location = genresLb.Location,
                Font = genresLb.Font,
                Text = title.Genres,
                ForeColor = genresLb.ForeColor,
                AutoSize = true
            };

            Label plot = new Label()
            {
                Location = plotLb.Location,
                Font = plotLb.Font,
                Text = title.Plot,
                AutoSize = false,
                Anchor = plotLb.Anchor,
                Size = plotLb.Size
            };

            string seasonsStr = title.Seasons.ToString();

            if (title.Seasons == 0)
                seasonsStr = "";
            else
                seasonsStr = seasonsStr + " seasons";

            Label seasons = new Label()
            {
                Font = seasonsLb.Font,
                Text = seasonsStr,
                AutoSize = true,
                ForeColor = seasonsLb.ForeColor
            };

            Label searchedFor = new Label()
            {
                Font = searchedForLbl.Font,
                Text = @"""" + title.Search + @"""",
                AutoSize = true,
                ForeColor = searchedForLbl.ForeColor
            };

            group.Controls.Add(movieTitle);
            group.Controls.Add(poster);
            group.Controls.Add(rating);
            group.Controls.Add(metascore);
            group.Controls.Add(genres);
            group.Controls.Add(plot);
            group.Controls.Add(seasons);
            group.Controls.Add(searchedFor);

            titleGroups.Add(new TitleGroup()
            {
                Group = group,
                Title = title
            });

            panel1.Controls.Add(group);

            searchedFor.Location = new Point(movieTitle.Size.Width + movieTitle.Location.X, searchedForLbl.Location.Y);
            metascore.Location = new Point(rating.Size.Width + rating.Location.X + 6, metascoreLb.Location.Y);
            seasons.Location = new Point(metascore.Size.Width + metascore.Location.X, seasonsLb.Location.Y);
            
            sortGroupBoxes();
        }

        private void sortGroupBoxes()
        {
            List<TitleGroup> ratingsOrdered;

            if (imdbRb.Checked)
                ratingsOrdered = titleGroups.OrderByDescending(x => x.Title.Rating).ToList();
            else
                ratingsOrdered = titleGroups.OrderByDescending(x => x.Title.Metascore).ToList();

            for (int i = 0; i < ratingsOrdered.Count; i++)
            {
                ratingsOrdered[i].Group.Location = new Point(TemplateGb.Location.X, i * (TemplateGb.Height + 10) - panel1.VerticalScroll.Value);

                string cardinal = (i+1).ToString();
                if (cardinal.EndsWith("1"))
                    cardinal = cardinal + "st";
                else if (cardinal.EndsWith("2"))
                    cardinal = cardinal + "nd";
                else if (cardinal.EndsWith("3"))
                    cardinal = cardinal + "rd";
                else
                    cardinal = cardinal + "th";

                ratingsOrdered[i].Group.Text = cardinal;
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            WebClient client = new WebClient();
            string data = client.DownloadString(listUrlTi.Text);

            Regex reg = new Regex(expressionTi.Text);
            MatchCollection matches = reg.Matches(data);

            List<string> titles = new List<string>();

            IMDbAPI imdb = new IMDbAPI();
            total = matches.Count;

            startTime = DateTime.Now;
            for (int i = 0; i < matches.Count; i++)
            {
                IMDbTitle title = imdb.loadTitle(matches[i].Groups[1].Value);
                currentTitle = title;
                count = i;

                worker.ReportProgress((i + 1) * 100 / matches.Count);
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            double progressPercentage = (double)(count + 1) * 100 / total;
            double seconds = (DateTime.Now - startTime).TotalSeconds;
            double remainingSecs = 100 * seconds / progressPercentage - seconds;
            double remainingMins = Math.Floor(remainingSecs / 60);
            double secondsFromMins = remainingSecs - Math.Floor(remainingSecs / 60) * 60;

            statusLb.Text = "Loading... " + progressPercentage.ToString("F2") + "% (" + (count + 1).ToString() + " / " + total.ToString() + ", " + remainingMins.ToString("F0") + " minutes " + secondsFromMins.ToString("F0") + " seconds)";
            progress.Value = e.ProgressPercentage;

            addTitle(currentTitle, count);
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            statusLb.Text = "Done!";
            searchBtn.Enabled = true;
            progress.Visible = false;
            imdbRb.Visible = true;
            metascoreRb.Visible = true;
        }

        private void movieTitle_Click(object sender, EventArgs e)
        {
            GroupBox group = (sender as Label).Parent as GroupBox;
            string link = "";

            foreach(TitleGroup titleGroup in titleGroups)
            {
                if (titleGroup.Group == group)
                {
                    link = titleGroup.Title.Link;
                    break;
                }
            }

            if (!string.IsNullOrEmpty(link))
                Process.Start(link);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.Focus();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TemplateReader reader = new TemplateReader();
            List<Template> templates = reader.loadTemplates();
            
            listBox1.DataSource = templates;
            listBox1.ValueMember = "Name";

            setSelectedTemplate();

            statusLb.Text = "";
        }

        private void setSelectedTemplate()
        {
            listUrlTi.Text = (listBox1.SelectedItem as Template).Link;
            expressionTi.Text = (listBox1.SelectedItem as Template).Expression;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setSelectedTemplate();
        }

        private void imdbRb_CheckedChanged(object sender, EventArgs e)
        {
            sortGroupBoxes();
        }

        private void metascoreRb_CheckedChanged(object sender, EventArgs e)
        {
            sortGroupBoxes();
        }

        private void posterPb_Click(object sender, EventArgs e)
        {
            GroupBox group = (sender as PictureBox).Parent as GroupBox;
            string link = "";

            foreach (TitleGroup titleGroup in titleGroups)
            {
                if (titleGroup.Group == group)
                {
                    link = titleGroup.Title.Poster;
                    break;
                }
            }

            Poster posterFrm = new Poster();

            if (link != "")
                posterFrm.link = link;

            posterFrm.ShowDialog();
        }

    }
}
