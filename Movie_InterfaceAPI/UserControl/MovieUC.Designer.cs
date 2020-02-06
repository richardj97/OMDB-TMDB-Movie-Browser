namespace Movie_InterfaceAPI
{
    partial class MovieUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieUC));
            this.TitleLb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WishListBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MoreInfoLl = new System.Windows.Forms.LinkLabel();
            this.SeenBtn = new System.Windows.Forms.Button();
            this.PosterPb = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PosterPb)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLb
            // 
            this.TitleLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.TitleLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLb.ForeColor = System.Drawing.Color.White;
            this.TitleLb.Location = new System.Drawing.Point(0, 0);
            this.TitleLb.Name = "TitleLb";
            this.TitleLb.Size = new System.Drawing.Size(146, 55);
            this.TitleLb.TabIndex = 1;
            this.TitleLb.Text = "Title";
            this.TitleLb.Click += new System.EventHandler(this.TitleLb_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TitleLb);
            this.panel1.Location = new System.Drawing.Point(95, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 55);
            this.panel1.TabIndex = 3;
            // 
            // WishListBtn
            // 
            this.WishListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.WishListBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.WishListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WishListBtn.ForeColor = System.Drawing.Color.White;
            this.WishListBtn.Location = new System.Drawing.Point(100, 81);
            this.WishListBtn.Name = "WishListBtn";
            this.WishListBtn.Size = new System.Drawing.Size(75, 23);
            this.WishListBtn.TabIndex = 5;
            this.WishListBtn.Text = "+ Wish List";
            this.WishListBtn.UseVisualStyleBackColor = false;
            this.WishListBtn.Click += new System.EventHandler(this.WishListBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.panel2.Controls.Add(this.MoreInfoLl);
            this.panel2.Controls.Add(this.SeenBtn);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 110);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // MoreInfoLl
            // 
            this.MoreInfoLl.AutoSize = true;
            this.MoreInfoLl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoreInfoLl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.MoreInfoLl.Location = new System.Drawing.Point(97, 62);
            this.MoreInfoLl.Name = "MoreInfoLl";
            this.MoreInfoLl.Size = new System.Drawing.Size(53, 12);
            this.MoreInfoLl.TabIndex = 8;
            this.MoreInfoLl.TabStop = true;
            this.MoreInfoLl.Text = "More info...";
            this.MoreInfoLl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MoreInfoLl_LinkClicked);
            // 
            // SeenBtn
            // 
            this.SeenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.SeenBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SeenBtn.FlatAppearance.BorderSize = 0;
            this.SeenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeenBtn.ForeColor = System.Drawing.Color.White;
            this.SeenBtn.Image = global::Movie_InterfaceAPI.Properties.Resources.icons8_eye_23;
            this.SeenBtn.Location = new System.Drawing.Point(212, 79);
            this.SeenBtn.Name = "SeenBtn";
            this.SeenBtn.Size = new System.Drawing.Size(23, 23);
            this.SeenBtn.TabIndex = 7;
            this.SeenBtn.UseVisualStyleBackColor = false;
            this.SeenBtn.Click += new System.EventHandler(this.SeenBtn_Click);
            // 
            // PosterPb
            // 
            this.PosterPb.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PosterPb.ErrorImage")));
            this.PosterPb.Location = new System.Drawing.Point(4, 4);
            this.PosterPb.Name = "PosterPb";
            this.PosterPb.Size = new System.Drawing.Size(87, 105);
            this.PosterPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PosterPb.TabIndex = 0;
            this.PosterPb.TabStop = false;
            this.PosterPb.Click += new System.EventHandler(this.PosterPb_Click);
            // 
            // MovieUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.WishListBtn);
            this.Controls.Add(this.PosterPb);
            this.Controls.Add(this.panel2);
            this.Name = "MovieUC";
            this.Size = new System.Drawing.Size(246, 112);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PosterPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PosterPb;
        private System.Windows.Forms.Label TitleLb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button WishListBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SeenBtn;
        private System.Windows.Forms.LinkLabel MoreInfoLl;
    }
}
