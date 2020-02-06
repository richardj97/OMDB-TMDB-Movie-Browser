namespace Movie_InterfaceAPI
{
    partial class WishList
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
            this.WishListBtn = new System.Windows.Forms.Button();
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
            // WishListBtn
            // 
            this.WishListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.WishListBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.WishListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WishListBtn.ForeColor = System.Drawing.Color.White;
            this.WishListBtn.Location = new System.Drawing.Point(13, 364);
            this.WishListBtn.Name = "WishListBtn";
            this.WishListBtn.Size = new System.Drawing.Size(88, 23);
            this.WishListBtn.TabIndex = 6;
            this.WishListBtn.Text = "Clear Wish List";
            this.WishListBtn.UseVisualStyleBackColor = false;
            this.WishListBtn.Click += new System.EventHandler(this.WishListBtn_Click);
            // 
            // WishList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(557, 396);
            this.Controls.Add(this.WishListBtn);
            this.Controls.Add(this.MoviesFLP);
            this.Name = "WishList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "My Wish List";
            this.Load += new System.EventHandler(this.WishList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MoviesFLP;
        private System.Windows.Forms.Button WishListBtn;
    }
}