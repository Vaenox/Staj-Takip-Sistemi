namespace Staj_Takip_Sistemi
{
	partial class stajyerYonetim
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stajyerYonetim));
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.sonuc = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelError = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.stajyerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stajyerAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stajyerSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.baslangicTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bitisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stajyerNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.departmanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stajyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.projeData = new Staj_Takip_Sistemi.ProjeData();
			this.ara = new System.Windows.Forms.Button();
			this.stajyerNo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.exitBtn = new System.Windows.Forms.PictureBox();
			this.minimizeBtn = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.stajyerTableAdapter = new Staj_Takip_Sistemi.ProjeDataTableAdapters.StajyerTableAdapter();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stajyerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.projeData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(1355, 728);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(116, 100);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 94;
			this.pictureBox2.TabStop = false;
			// 
			// sonuc
			// 
			this.sonuc.AutoSize = true;
			this.sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.sonuc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.sonuc.Location = new System.Drawing.Point(1102, 578);
			this.sonuc.Name = "sonuc";
			this.sonuc.Size = new System.Drawing.Size(194, 25);
			this.sonuc.TabIndex = 93;
			this.sonuc.Text = "(1)Sonuç Bulundu!";
			this.sonuc.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(1005, 612);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(466, 25);
			this.label3.TabIndex = 92;
			this.label3.Text = "Stajyer Numarası Sadece Rakamlardan Oluşur!";
			this.label3.Visible = false;
			// 
			// labelError
			// 
			this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelError.ForeColor = System.Drawing.Color.White;
			this.labelError.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelError.Location = new System.Drawing.Point(1016, 612);
			this.labelError.Name = "labelError";
			this.labelError.Size = new System.Drawing.Size(415, 34);
			this.labelError.TabIndex = 91;
			this.labelError.Text = "Böyle bir Stajyer Bulunamadı!";
			this.labelError.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.labelError.Visible = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stajyerIDDataGridViewTextBoxColumn,
            this.stajyerAdDataGridViewTextBoxColumn,
            this.stajyerSoyadDataGridViewTextBoxColumn,
            this.baslangicTarihDataGridViewTextBoxColumn,
            this.bitisTarihDataGridViewTextBoxColumn,
            this.stajyerNoDataGridViewTextBoxColumn,
            this.personelIDDataGridViewTextBoxColumn,
            this.departmanIDDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.stajyerBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 47);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(998, 683);
			this.dataGridView1.TabIndex = 90;
			// 
			// stajyerIDDataGridViewTextBoxColumn
			// 
			this.stajyerIDDataGridViewTextBoxColumn.DataPropertyName = "stajyerID";
			this.stajyerIDDataGridViewTextBoxColumn.HeaderText = "stajyerID";
			this.stajyerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.stajyerIDDataGridViewTextBoxColumn.Name = "stajyerIDDataGridViewTextBoxColumn";
			this.stajyerIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.stajyerIDDataGridViewTextBoxColumn.Width = 125;
			// 
			// stajyerAdDataGridViewTextBoxColumn
			// 
			this.stajyerAdDataGridViewTextBoxColumn.DataPropertyName = "stajyerAd";
			this.stajyerAdDataGridViewTextBoxColumn.HeaderText = "stajyerAd";
			this.stajyerAdDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.stajyerAdDataGridViewTextBoxColumn.Name = "stajyerAdDataGridViewTextBoxColumn";
			this.stajyerAdDataGridViewTextBoxColumn.ReadOnly = true;
			this.stajyerAdDataGridViewTextBoxColumn.Width = 125;
			// 
			// stajyerSoyadDataGridViewTextBoxColumn
			// 
			this.stajyerSoyadDataGridViewTextBoxColumn.DataPropertyName = "stajyerSoyad";
			this.stajyerSoyadDataGridViewTextBoxColumn.HeaderText = "stajyerSoyad";
			this.stajyerSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.stajyerSoyadDataGridViewTextBoxColumn.Name = "stajyerSoyadDataGridViewTextBoxColumn";
			this.stajyerSoyadDataGridViewTextBoxColumn.ReadOnly = true;
			this.stajyerSoyadDataGridViewTextBoxColumn.Width = 125;
			// 
			// baslangicTarihDataGridViewTextBoxColumn
			// 
			this.baslangicTarihDataGridViewTextBoxColumn.DataPropertyName = "baslangicTarih";
			this.baslangicTarihDataGridViewTextBoxColumn.HeaderText = "baslangicTarih";
			this.baslangicTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.baslangicTarihDataGridViewTextBoxColumn.Name = "baslangicTarihDataGridViewTextBoxColumn";
			this.baslangicTarihDataGridViewTextBoxColumn.ReadOnly = true;
			this.baslangicTarihDataGridViewTextBoxColumn.Width = 125;
			// 
			// bitisTarihDataGridViewTextBoxColumn
			// 
			this.bitisTarihDataGridViewTextBoxColumn.DataPropertyName = "bitisTarih";
			this.bitisTarihDataGridViewTextBoxColumn.HeaderText = "bitisTarih";
			this.bitisTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.bitisTarihDataGridViewTextBoxColumn.Name = "bitisTarihDataGridViewTextBoxColumn";
			this.bitisTarihDataGridViewTextBoxColumn.ReadOnly = true;
			this.bitisTarihDataGridViewTextBoxColumn.Width = 125;
			// 
			// stajyerNoDataGridViewTextBoxColumn
			// 
			this.stajyerNoDataGridViewTextBoxColumn.DataPropertyName = "stajyerNo";
			this.stajyerNoDataGridViewTextBoxColumn.HeaderText = "stajyerNo";
			this.stajyerNoDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.stajyerNoDataGridViewTextBoxColumn.Name = "stajyerNoDataGridViewTextBoxColumn";
			this.stajyerNoDataGridViewTextBoxColumn.ReadOnly = true;
			this.stajyerNoDataGridViewTextBoxColumn.Width = 125;
			// 
			// personelIDDataGridViewTextBoxColumn
			// 
			this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "personelID";
			this.personelIDDataGridViewTextBoxColumn.HeaderText = "personelID";
			this.personelIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
			this.personelIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.personelIDDataGridViewTextBoxColumn.Width = 125;
			// 
			// departmanIDDataGridViewTextBoxColumn
			// 
			this.departmanIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmanID";
			this.departmanIDDataGridViewTextBoxColumn.HeaderText = "DepartmanID";
			this.departmanIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.departmanIDDataGridViewTextBoxColumn.Name = "departmanIDDataGridViewTextBoxColumn";
			this.departmanIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.departmanIDDataGridViewTextBoxColumn.Width = 125;
			// 
			// stajyerBindingSource
			// 
			this.stajyerBindingSource.DataMember = "Stajyer";
			this.stajyerBindingSource.DataSource = this.projeData;
			// 
			// projeData
			// 
			this.projeData.DataSetName = "ProjeData";
			this.projeData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ara
			// 
			this.ara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(211)))), ((int)(((byte)(226)))));
			this.ara.FlatAppearance.BorderSize = 0;
			this.ara.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ara.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.ara.Location = new System.Drawing.Point(1144, 523);
			this.ara.Margin = new System.Windows.Forms.Padding(4);
			this.ara.Name = "ara";
			this.ara.Size = new System.Drawing.Size(183, 37);
			this.ara.TabIndex = 89;
			this.ara.Text = "Stajyer Ara";
			this.ara.UseVisualStyleBackColor = false;
			this.ara.Click += new System.EventHandler(this.ara_Click);
			// 
			// stajyerNo
			// 
			this.stajyerNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
			this.stajyerNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stajyerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.stajyerNo.Location = new System.Drawing.Point(1187, 465);
			this.stajyerNo.Margin = new System.Windows.Forms.Padding(4);
			this.stajyerNo.Name = "stajyerNo";
			this.stajyerNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.stajyerNo.Size = new System.Drawing.Size(202, 27);
			this.stajyerNo.TabIndex = 88;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(1001, 463);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(189, 38);
			this.label8.TabIndex = 87;
			this.label8.Text = "Stajyer No:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(-38, 31);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(34, 28);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 86;
			this.pictureBox3.TabStop = false;
			// 
			// exitBtn
			// 
			this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
			this.exitBtn.Location = new System.Drawing.Point(1422, 13);
			this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(37, 28);
			this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.exitBtn.TabIndex = 85;
			this.exitBtn.TabStop = false;
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			// 
			// minimizeBtn
			// 
			this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
			this.minimizeBtn.Location = new System.Drawing.Point(1377, 20);
			this.minimizeBtn.Margin = new System.Windows.Forms.Padding(4);
			this.minimizeBtn.Name = "minimizeBtn";
			this.minimizeBtn.Size = new System.Drawing.Size(37, 21);
			this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.minimizeBtn.TabIndex = 84;
			this.minimizeBtn.TabStop = false;
			this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(1107, 135);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(307, 266);
			this.pictureBox1.TabIndex = 83;
			this.pictureBox1.TabStop = false;
			// 
			// stajyerTableAdapter
			// 
			this.stajyerTableAdapter.ClearBeforeFill = true;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(12, 13);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(34, 28);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 95;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// stajyerYonetim
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
			this.ClientSize = new System.Drawing.Size(1472, 832);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.sonuc);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelError);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.ara);
			this.Controls.Add(this.stajyerNo);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.minimizeBtn);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "stajyerYonetim";
			this.Text = "stajyerYonetim";
			this.Load += new System.EventHandler(this.stajyerYonetim_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stajyerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.projeData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label sonuc;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelError;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button ara;
		private System.Windows.Forms.TextBox stajyerNo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox exitBtn;
		private System.Windows.Forms.PictureBox minimizeBtn;
		private System.Windows.Forms.PictureBox pictureBox1;
		private ProjeData projeData;
		private System.Windows.Forms.BindingSource stajyerBindingSource;
		private ProjeDataTableAdapters.StajyerTableAdapter stajyerTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn stajyerIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn stajyerAdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn stajyerSoyadDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn baslangicTarihDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bitisTarihDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn stajyerNoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn departmanIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}