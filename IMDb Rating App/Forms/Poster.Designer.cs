namespace IMDb_Rating_App.Forms
{
    partial class Poster
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
            this.posterPb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.posterPb)).BeginInit();
            this.SuspendLayout();
            // 
            // posterPb
            // 
            this.posterPb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.posterPb.Location = new System.Drawing.Point(0, 0);
            this.posterPb.Name = "posterPb";
            this.posterPb.Size = new System.Drawing.Size(621, 498);
            this.posterPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.posterPb.TabIndex = 0;
            this.posterPb.TabStop = false;
            // 
            // Poster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 498);
            this.Controls.Add(this.posterPb);
            this.MinimizeBox = false;
            this.Name = "Poster";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Poster";
            this.Shown += new System.EventHandler(this.Poster_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.posterPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox posterPb;
    }
}