using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMDb_Rating_App.Forms
{
    public partial class Poster : Form
    {
        public string link;

        public Poster()
        {
            InitializeComponent();
        }

        private void Poster_Shown(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(link))
                return;

            posterPb.Load(link);

            int SCREEN_PADDING = 100;

            int desiredWidth =  posterPb.Image.Size.Width + (Size.Width - posterPb.Size.Width);
            int desiredHeight = posterPb.Image.Size.Height + (Size.Height - posterPb.Size.Height);
            double actualWidth = desiredWidth;
            double actualHeight = desiredHeight;
            Size screenSize = Screen.PrimaryScreen.Bounds.Size;

            if (desiredHeight + SCREEN_PADDING > screenSize.Height)
            {
                actualHeight = desiredHeight - (-screenSize.Height + SCREEN_PADDING + desiredHeight);
                actualWidth = desiredWidth * (actualHeight / desiredHeight);
            }

            if (desiredWidth + SCREEN_PADDING > screenSize.Width)
            {
                actualWidth = desiredWidth - (-screenSize.Width + SCREEN_PADDING + desiredWidth);
                actualHeight = desiredHeight * (actualWidth / desiredWidth);
            }

            Size = new Size() {
                Width = (int)Math.Round(actualWidth),
                Height = (int)Math.Round(actualHeight)
            };
        }
    }
}
