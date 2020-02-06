namespace Movie_InterfaceAPI
{
    partial class WishListUC
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
            this.WishListBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WishListLb = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // WishListBtn
            // 
            this.WishListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.WishListBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.WishListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WishListBtn.ForeColor = System.Drawing.Color.White;
            this.WishListBtn.Location = new System.Drawing.Point(77, 74);
            this.WishListBtn.Name = "WishListBtn";
            this.WishListBtn.Size = new System.Drawing.Size(87, 23);
            this.WishListBtn.TabIndex = 8;
            this.WishListBtn.Text = "View Wish List";
            this.WishListBtn.UseVisualStyleBackColor = false;
            this.WishListBtn.Click += new System.EventHandler(this.WishListBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.panel2.Controls.Add(this.WishListLb);
            this.panel2.Controls.Add(this.WishListBtn);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 110);
            this.panel2.TabIndex = 9;
            // 
            // WishListLb
            // 
            this.WishListLb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WishListLb.ForeColor = System.Drawing.Color.White;
            this.WishListLb.Location = new System.Drawing.Point(14, 8);
            this.WishListLb.Name = "WishListLb";
            this.WishListLb.Size = new System.Drawing.Size(218, 57);
            this.WishListLb.TabIndex = 9;
            this.WishListLb.Text = "There are currently 0 movies in your wish list";
            this.WishListLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WishListLb.Click += new System.EventHandler(this.WishListLb_Click);
            // 
            // WishListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "WishListUC";
            this.Size = new System.Drawing.Size(246, 112);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button WishListBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label WishListLb;
    }
}
