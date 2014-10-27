namespace IMDb_Rating_App
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.listUrlTi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.expressionTi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.statusLb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TemplateGb = new System.Windows.Forms.GroupBox();
            this.searchedForLbl = new System.Windows.Forms.Label();
            this.seasonsLb = new System.Windows.Forms.Label();
            this.plotLb = new System.Windows.Forms.Label();
            this.genresLb = new System.Windows.Forms.Label();
            this.ratingLb = new System.Windows.Forms.Label();
            this.posterPb = new System.Windows.Forms.PictureBox();
            this.titleLb = new System.Windows.Forms.Label();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.metascoreLb = new System.Windows.Forms.Label();
            this.imdbRb = new System.Windows.Forms.RadioButton();
            this.metascoreRb = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.TemplateGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posterPb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie list URL:";
            // 
            // listUrlTi
            // 
            this.listUrlTi.Location = new System.Drawing.Point(119, 10);
            this.listUrlTi.Name = "listUrlTi";
            this.listUrlTi.Size = new System.Drawing.Size(297, 20);
            this.listUrlTi.TabIndex = 1;
            this.listUrlTi.Text = "http://serialepenet.ro/western";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Regular expression:";
            // 
            // expressionTi
            // 
            this.expressionTi.Location = new System.Drawing.Point(119, 36);
            this.expressionTi.Name = "expressionTi";
            this.expressionTi.Size = new System.Drawing.Size(297, 20);
            this.expressionTi.TabIndex = 3;
            this.expressionTi.Text = "<div class=\'serial_title\'>(.*)</div></a>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Templates:";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(524, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 95);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(16, 81);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchClick);
            // 
            // statusLb
            // 
            this.statusLb.AutoSize = true;
            this.statusLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusLb.Location = new System.Drawing.Point(116, 76);
            this.statusLb.Name = "statusLb";
            this.statusLb.Size = new System.Drawing.Size(244, 13);
            this.statusLb.TabIndex = 7;
            this.statusLb.Text = "Loading... 36.50% (5 minutes 10 seconds)";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.TemplateGb);
            this.panel1.Location = new System.Drawing.Point(16, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 588);
            this.panel1.TabIndex = 8;
            this.panel1.TabStop = true;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // TemplateGb
            // 
            this.TemplateGb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TemplateGb.Controls.Add(this.metascoreLb);
            this.TemplateGb.Controls.Add(this.searchedForLbl);
            this.TemplateGb.Controls.Add(this.seasonsLb);
            this.TemplateGb.Controls.Add(this.plotLb);
            this.TemplateGb.Controls.Add(this.genresLb);
            this.TemplateGb.Controls.Add(this.ratingLb);
            this.TemplateGb.Controls.Add(this.posterPb);
            this.TemplateGb.Controls.Add(this.titleLb);
            this.TemplateGb.Location = new System.Drawing.Point(4, 4);
            this.TemplateGb.Name = "TemplateGb";
            this.TemplateGb.Size = new System.Drawing.Size(720, 188);
            this.TemplateGb.TabIndex = 0;
            this.TemplateGb.TabStop = false;
            this.TemplateGb.Text = "1st";
            this.TemplateGb.Visible = false;
            // 
            // searchedForLbl
            // 
            this.searchedForLbl.AutoSize = true;
            this.searchedForLbl.ForeColor = System.Drawing.Color.Gray;
            this.searchedForLbl.Location = new System.Drawing.Point(374, 24);
            this.searchedForLbl.Name = "searchedForLbl";
            this.searchedForLbl.Size = new System.Drawing.Size(171, 13);
            this.searchedForLbl.TabIndex = 6;
            this.searchedForLbl.Text = "(Searched for: \"Enter the Dragon\")";
            // 
            // seasonsLb
            // 
            this.seasonsLb.AutoSize = true;
            this.seasonsLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seasonsLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(108)))), ((int)(((byte)(178)))));
            this.seasonsLb.Location = new System.Drawing.Point(430, 48);
            this.seasonsLb.Name = "seasonsLb";
            this.seasonsLb.Size = new System.Drawing.Size(73, 17);
            this.seasonsLb.TabIndex = 5;
            this.seasonsLb.Text = "3 seasons";
            // 
            // plotLb
            // 
            this.plotLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plotLb.Location = new System.Drawing.Point(164, 103);
            this.plotLb.Name = "plotLb";
            this.plotLb.Size = new System.Drawing.Size(550, 68);
            this.plotLb.TabIndex = 4;
            this.plotLb.Text = "Hansel & Gretel are bounty hunters who track and kill witches all over the world." +
    " As the fabled Blood Moon approaches, the siblings encounter a new form of evil " +
    "that might hold a secret to their past.";
            // 
            // genresLb
            // 
            this.genresLb.AutoSize = true;
            this.genresLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.genresLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.genresLb.Location = new System.Drawing.Point(164, 74);
            this.genresLb.Name = "genresLb";
            this.genresLb.Size = new System.Drawing.Size(141, 17);
            this.genresLb.TabIndex = 3;
            this.genresLb.Text = "Action, Crime, Drama";
            // 
            // ratingLb
            // 
            this.ratingLb.AutoSize = true;
            this.ratingLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(127)))));
            this.ratingLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ratingLb.Location = new System.Drawing.Point(164, 45);
            this.ratingLb.Name = "ratingLb";
            this.ratingLb.Padding = new System.Windows.Forms.Padding(3);
            this.ratingLb.Size = new System.Drawing.Size(118, 23);
            this.ratingLb.TabIndex = 2;
            this.ratingLb.Text = "7.60 IMDb rating";
            // 
            // posterPb
            // 
            this.posterPb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.posterPb.Location = new System.Drawing.Point(7, 20);
            this.posterPb.Name = "posterPb";
            this.posterPb.Size = new System.Drawing.Size(132, 151);
            this.posterPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.posterPb.TabIndex = 1;
            this.posterPb.TabStop = false;
            this.posterPb.Click += new System.EventHandler(this.posterPb_Click);
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.titleLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLb.Location = new System.Drawing.Point(163, 20);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(205, 20);
            this.titleLb.TabIndex = 0;
            this.titleLb.Text = "Enter the Dragon (1973)";
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(119, 92);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(297, 19);
            this.progress.Step = 1;
            this.progress.TabIndex = 9;
            this.progress.Visible = false;
            // 
            // metascoreLb
            // 
            this.metascoreLb.AutoSize = true;
            this.metascoreLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.metascoreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.metascoreLb.ForeColor = System.Drawing.Color.White;
            this.metascoreLb.Location = new System.Drawing.Point(288, 45);
            this.metascoreLb.Name = "metascoreLb";
            this.metascoreLb.Padding = new System.Windows.Forms.Padding(3);
            this.metascoreLb.Size = new System.Drawing.Size(136, 23);
            this.metascoreLb.TabIndex = 7;
            this.metascoreLb.Text = "66 / 100 Metascore";
            // 
            // imdbRb
            // 
            this.imdbRb.AutoSize = true;
            this.imdbRb.Checked = true;
            this.imdbRb.Location = new System.Drawing.Point(119, 94);
            this.imdbRb.Name = "imdbRb";
            this.imdbRb.Size = new System.Drawing.Size(51, 17);
            this.imdbRb.TabIndex = 10;
            this.imdbRb.TabStop = true;
            this.imdbRb.Text = "IMDb";
            this.imdbRb.UseVisualStyleBackColor = true;
            this.imdbRb.Visible = false;
            this.imdbRb.CheckedChanged += new System.EventHandler(this.imdbRb_CheckedChanged);
            // 
            // metascoreRb
            // 
            this.metascoreRb.AutoSize = true;
            this.metascoreRb.Location = new System.Drawing.Point(177, 94);
            this.metascoreRb.Name = "metascoreRb";
            this.metascoreRb.Size = new System.Drawing.Size(75, 17);
            this.metascoreRb.TabIndex = 11;
            this.metascoreRb.Text = "Metascore";
            this.metascoreRb.UseVisualStyleBackColor = true;
            this.metascoreRb.Visible = false;
            this.metascoreRb.CheckedChanged += new System.EventHandler(this.metascoreRb_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 722);
            this.Controls.Add(this.metascoreRb);
            this.Controls.Add(this.imdbRb);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusLb);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.expressionTi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listUrlTi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "IMDb Rating App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.TemplateGb.ResumeLayout(false);
            this.TemplateGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posterPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox listUrlTi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox expressionTi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label statusLb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox TemplateGb;
        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.PictureBox posterPb;
        private System.Windows.Forms.Label ratingLb;
        private System.Windows.Forms.Label genresLb;
        private System.Windows.Forms.Label plotLb;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Label seasonsLb;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label searchedForLbl;
        private System.Windows.Forms.Label metascoreLb;
        private System.Windows.Forms.RadioButton imdbRb;
        private System.Windows.Forms.RadioButton metascoreRb;

    }
}

