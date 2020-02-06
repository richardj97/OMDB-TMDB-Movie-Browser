namespace Movie_InterfaceAPI
{
    partial class MovieInfo
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
            this.PosterPb = new System.Windows.Forms.PictureBox();
            this.ResultsLb = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PosterPb)).BeginInit();
            this.SuspendLayout();
            // 
            // PosterPb
            // 
            this.PosterPb.ErrorImage = global::Movie_InterfaceAPI.Properties.Resources.Webp_net_resizeimage;
            this.PosterPb.Location = new System.Drawing.Point(12, 12);
            this.PosterPb.Name = "PosterPb";
            this.PosterPb.Size = new System.Drawing.Size(87, 105);
            this.PosterPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PosterPb.TabIndex = 1;
            this.PosterPb.TabStop = false;
            // 
            // ResultsLb
            // 
            this.ResultsLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.ResultsLb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultsLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsLb.ForeColor = System.Drawing.Color.White;
            this.ResultsLb.FormattingEnabled = true;
            this.ResultsLb.Location = new System.Drawing.Point(105, 12);
            this.ResultsLb.Name = "ResultsLb";
            this.ResultsLb.Size = new System.Drawing.Size(463, 301);
            this.ResultsLb.TabIndex = 3;
            // 
            // MovieInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(580, 339);
            this.Controls.Add(this.ResultsLb);
            this.Controls.Add(this.PosterPb);
            this.Name = "MovieInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Movie Info";
            this.Load += new System.EventHandler(this.MovieInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PosterPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PosterPb;
        private System.Windows.Forms.ListBox ResultsLb;
    }
}