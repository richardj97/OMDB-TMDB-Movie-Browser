namespace Movie_InterfaceAPI
{
    partial class SeenListUC
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
            this.SeenListLb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SeenListBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeenListLb
            // 
            this.SeenListLb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeenListLb.ForeColor = System.Drawing.Color.White;
            this.SeenListLb.Location = new System.Drawing.Point(14, 8);
            this.SeenListLb.Name = "SeenListLb";
            this.SeenListLb.Size = new System.Drawing.Size(218, 57);
            this.SeenListLb.TabIndex = 9;
            this.SeenListLb.Text = "You have seen 0 movies in this search category";
            this.SeenListLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SeenListLb.Click += new System.EventHandler(this.SeenListLb_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.panel2.Controls.Add(this.SeenListLb);
            this.panel2.Controls.Add(this.SeenListBtn);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 110);
            this.panel2.TabIndex = 10;
            // 
            // SeenListBtn
            // 
            this.SeenListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.SeenListBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SeenListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeenListBtn.ForeColor = System.Drawing.Color.White;
            this.SeenListBtn.Location = new System.Drawing.Point(77, 74);
            this.SeenListBtn.Name = "SeenListBtn";
            this.SeenListBtn.Size = new System.Drawing.Size(87, 23);
            this.SeenListBtn.TabIndex = 8;
            this.SeenListBtn.Text = "View Seen List";
            this.SeenListBtn.UseVisualStyleBackColor = false;
            this.SeenListBtn.Click += new System.EventHandler(this.SeenListBtn_Click);
            // 
            // SeenListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "SeenListUC";
            this.Size = new System.Drawing.Size(246, 112);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SeenListLb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SeenListBtn;
    }
}
