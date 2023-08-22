namespace Staj_Takip_Sistemi
{
    partial class personelEkranı
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personelEkranı));
			this.minimizeBtn = new System.Windows.Forms.PictureBox();
			this.exitBtn = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// minimizeBtn
			// 
			this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
			this.minimizeBtn.Location = new System.Drawing.Point(1278, 15);
			this.minimizeBtn.Margin = new System.Windows.Forms.Padding(4);
			this.minimizeBtn.Name = "minimizeBtn";
			this.minimizeBtn.Size = new System.Drawing.Size(37, 21);
			this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.minimizeBtn.TabIndex = 8;
			this.minimizeBtn.TabStop = false;
			this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
			// 
			// exitBtn
			// 
			this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
			this.exitBtn.Location = new System.Drawing.Point(1323, 13);
			this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(37, 28);
			this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.exitBtn.TabIndex = 7;
			this.exitBtn.TabStop = false;
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			this.exitBtn.MouseHover += new System.EventHandler(this.exitBtn_MouseHover);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(520, 115);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(296, 270);
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(12, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(33, 35);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			// 
			// personelEkranı
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
			this.ClientSize = new System.Drawing.Size(1373, 769);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.minimizeBtn);
			this.Controls.Add(this.exitBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "personelEkranı";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "personelEkranı";
			this.Load += new System.EventHandler(this.personelEkranı_Load);
			((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.PictureBox exitBtn;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}