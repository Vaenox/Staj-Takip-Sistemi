using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj_Takip_Sistemi
{
	public partial class yoneticiPanel : Form
	{
		public yoneticiPanel()
		{
			InitializeComponent();
		}

		SqlConnection con;
		SqlCommand cmd;
		SqlDataReader dr;
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4UEBQES\\SQLEXPRESS;Initial Catalog=StajProje;Integrated Security=True");



		private void yoneticiPanel_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			stajyerYonetim sYonetim = new stajyerYonetim();
			sYonetim.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			baglanti.Open();


			string sorgu1 = "SELECT COUNT(*) FROM Stajyer WHERE stajyerNo = @stajyerNo";
			SqlCommand komut = new SqlCommand(sorgu1, baglanti);
			komut.Parameters.AddWithValue("@stajyerNo", stajyerNo.Text);
			int rowCount = (int)komut.ExecuteScalar();

			if (rowCount == 0)
			{
				string sorgu = "INSERT INTO Stajyer(stajyerAd,stajyerSoyad,departmanAdi,stajyerNo,baslangicTarih,bitisTarih)" +
				"values (@stajyerAd,@stajyerSoyad,@departmanAdi,@stajyerNo,@baslangicTarih,@bitisTarih)";
				komut = new SqlCommand(sorgu, baglanti);
				komut.Parameters.AddWithValue("@stajyerAd", stajyerAd.Text);
				komut.Parameters.AddWithValue("@stajyerSoyad", stajyerSoyad.Text);
				komut.Parameters.AddWithValue("@departmanAdi", stajyerDepartman.Text);
				komut.Parameters.AddWithValue("@stajyerNo", stajyerNo.Text);
				komut.Parameters.AddWithValue("@baslangicTarih", stajBaslangic.Text);
				komut.Parameters.AddWithValue("@bitisTarih", stajBitis.Text);


				komut.ExecuteNonQuery();

				MessageBox.Show("Stajyer Kaydedildi!");
			}
			else
			{

			}
			baglanti.Close();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			baglanti.Open();

			string sorgu1 = "SELECT COUNT(*) FROM Stajyer WHERE stajyerNo = @stajyerNo";
			SqlCommand komut = new SqlCommand(sorgu1, baglanti);
			komut.Parameters.AddWithValue("@stajyerNo", stajyerNo.Text);
			int rowCount = (int)komut.ExecuteScalar();

			if (rowCount > 0)
			{
				string sorgu = "DELETE FROM Stajyer WHERE stajyerNo = @stajyerNo";
				komut = new SqlCommand(sorgu, baglanti);
				komut.Parameters.AddWithValue("@stajyerNo", stajyerNo.Text);

				komut.ExecuteNonQuery();

				MessageBox.Show("Stajyer Silindi!");
			}
			else
			{
				MessageBox.Show("Bu stajyer numarasına sahip bir kayıt bulunamadı.");
			}
			baglanti.Close();
		}

		private void exitBtn_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void minimizeBtn_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			yoneticiGiris yGiris = new yoneticiGiris();
			yGiris.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			baglanti.Open();

			string sorgu1 = "SELECT COUNT(*) FROM Stajyer WHERE stajyerNo = @stajyerNo";
			SqlCommand komut = new SqlCommand(sorgu1, baglanti);
			komut.Parameters.AddWithValue("@stajyerNo", stajyerNo.Text);
			int rowCount = (int)komut.ExecuteScalar();

			if (rowCount > 0)
			{
				string sorgu = "UPDATE Stajyer SET stajyerAd = @stajyerAd, stajyerSoyad = @stajyerSoyad, departmanAdi = @departmanAdi, " +
							   "baslangicTarih = @baslangicTarih, bitisTarih = @bitisTarih WHERE stajyerNo = @stajyerNo";
				komut = new SqlCommand(sorgu, baglanti);
				komut.Parameters.AddWithValue("@stajyerAd", stajyerAd.Text);
				komut.Parameters.AddWithValue("@stajyerSoyad", stajyerSoyad.Text);
				komut.Parameters.AddWithValue("@departmanAdi", stajyerDepartman.Text);
				komut.Parameters.AddWithValue("@stajyerNo", stajyerNo.Text);
				komut.Parameters.AddWithValue("@baslangicTarih", stajBaslangic.Text);
				komut.Parameters.AddWithValue("@bitisTarih", stajBitis.Text);

				komut.ExecuteNonQuery();

				MessageBox.Show("Stajyer Bilgileri Güncellendi!");
			}
			else
			{
				MessageBox.Show("Bu stajyer numarasına sahip bir kayıt bulunamadı.");
			}
			baglanti.Close();



		}
	}
}
