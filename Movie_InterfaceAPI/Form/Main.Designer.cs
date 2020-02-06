namespace Movie_InterfaceAPI
{
	partial class Main
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
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MoviesFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MultipleCb = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ThreadBW = new System.ComponentModel.BackgroundWorker();
            this.LoadPb = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadPb)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchPanel
            // 
            this.SearchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPanel.Controls.Add(this.SearchBtn);
            this.SearchPanel.Controls.Add(this.SearchTb);
            this.SearchPanel.Location = new System.Drawing.Point(520, 12);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(311, 34);
            this.SearchPanel.TabIndex = 0;
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Image = global::Movie_InterfaceAPI.Properties.Resources.icons8_search_22;
            this.SearchBtn.Location = new System.Drawing.Point(274, 3);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(29, 25);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTb
            // 
            this.SearchTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.SearchTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTb.ForeColor = System.Drawing.Color.White;
            this.SearchTb.Location = new System.Drawing.Point(8, 7);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(252, 17);
            this.SearchTb.TabIndex = 0;
            this.SearchTb.Text = "Search for movie title...";
            this.SearchTb.Enter += new System.EventHandler(this.SearchTb_Enter);
            this.SearchTb.Leave += new System.EventHandler(this.SearchTb_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "OMDB Movie Client";
            // 
            // MoviesFLP
            // 
            this.MoviesFLP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesFLP.AutoScroll = true;
            this.MoviesFLP.Location = new System.Drawing.Point(12, 83);
            this.MoviesFLP.Name = "MoviesFLP";
            this.MoviesFLP.Size = new System.Drawing.Size(819, 491);
            this.MoviesFLP.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 1);
            this.panel1.TabIndex = 3;
            // 
            // MultipleCb
            // 
            this.MultipleCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MultipleCb.AutoSize = true;
            this.MultipleCb.Checked = true;
            this.MultipleCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MultipleCb.ForeColor = System.Drawing.Color.White;
            this.MultipleCb.Location = new System.Drawing.Point(732, 53);
            this.MultipleCb.Name = "MultipleCb";
            this.MultipleCb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MultipleCb.Size = new System.Drawing.Size(99, 17);
            this.MultipleCb.TabIndex = 4;
            this.MultipleCb.Text = "Search Multiple";
            this.MultipleCb.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Created by Richard Jacobs, Simon West, Alisdair Keay, Diogo Ribeiro and Jason Mal" +
    "colm";
            // 
            // ThreadBW
            // 
            this.ThreadBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ThreadBW_DoWork);
            this.ThreadBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ThreadBW_RunWorkerCompleted);
            // 
            // LoadPb
            // 
            this.LoadPb.Image = global::Movie_InterfaceAPI.Properties.Resources.loadingImage;
            this.LoadPb.Location = new System.Drawing.Point(352, 264);
            this.LoadPb.Name = "LoadPb";
            this.LoadPb.Size = new System.Drawing.Size(62, 66);
            this.LoadPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadPb.TabIndex = 0;
            this.LoadPb.TabStop = false;
            this.LoadPb.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "OMDB",
            "TMDB"});
            this.comboBox1.Location = new System.Drawing.Point(597, 52);
            this.comboBox1.MaxDropDownItems = 2;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(526, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select API";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(843, 586);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LoadPb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MultipleCb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MoviesFLP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchPanel);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OMDB Movie Client (v.015)";
            this.Load += new System.EventHandler(this.Main_Load);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel SearchPanel;
		private System.Windows.Forms.Button SearchBtn;
		private System.Windows.Forms.TextBox SearchTb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel MoviesFLP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox MultipleCb;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker ThreadBW;
        private System.Windows.Forms.PictureBox LoadPb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}

