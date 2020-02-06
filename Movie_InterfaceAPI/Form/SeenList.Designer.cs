namespace Movie_InterfaceAPI
{
    partial class SeenList
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
            this.MoviesFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.SeenListBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MoviesFLP
            // 
            this.MoviesFLP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesFLP.AutoScroll = true;
            this.MoviesFLP.Location = new System.Drawing.Point(13, 13);
            this.MoviesFLP.Name = "MoviesFLP";
            this.MoviesFLP.Size = new System.Drawing.Size(532, 345);
            this.MoviesFLP.TabIndex = 0;
            // 
            // SeenListBtn
            // 
            this.SeenListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.SeenListBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SeenListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeenListBtn.ForeColor = System.Drawing.Color.White;
            this.SeenListBtn.Location = new System.Drawing.Point(13, 364);
            this.SeenListBtn.Name = "SeenListBtn";
            this.SeenListBtn.Size = new System.Drawing.Size(88, 23);
            this.SeenListBtn.TabIndex = 6;
            this.SeenListBtn.Text = "Clear Seen List";
            this.SeenListBtn.UseVisualStyleBackColor = false;
            this.SeenListBtn.Click += new System.EventHandler(this.WishListBtn_Click);
            // 
            // SeenList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(557, 396);
            this.Controls.Add(this.SeenListBtn);
            this.Controls.Add(this.MoviesFLP);
            this.Name = "SeenList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "A list of movies that i have seen";
            this.Load += new System.EventHandler(this.WishList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MoviesFLP;
        private System.Windows.Forms.Button SeenListBtn;
    }
}