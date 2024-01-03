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
	public partial class adminPanel : Form
	{
		public adminPanel()
		{
			InitializeComponent();

			comboBox1.Items.Add("Personel");
			comboBox1.Items.Add("Yönetici");			
		}

		SqlConnection con;
		SqlCommand cmd;
		SqlDataReader dr;
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4UEBQES\\SQLEXPRESS;Initial Catalog=StajProje;Integrated Security=True");


		private void pictureBox3_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(pictureBox3, "Geri");
		}

		private void minimizeBtn_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(pictureBox3, "Küçült");
		}

		private void exitBtn_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(pictureBox3, "Kapat");
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			adminGiris aGiris = new adminGiris();
			aGiris.Show();
			this.Hide();
		}

		private void minimizeBtn_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void exitBtn_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void adminPanel_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'projeData.Personel' table. You can move, or remove it, as needed.
			this.personelTableAdapter.Fill(this.projeData.Personel);

		}

		private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			

			string secilenSecenek = comboBox1.SelectedItem.ToString();

			if (secilenSecenek == "Personel")
			{
				personeltxt.Visible = true;
				personelAd.Visible = true;
				personelAdtxt.Visible = true;
				personelSoyad.Visible = true;
				personelSoyadtxt.Visible = true;
				personelDepartman.Visible = true;
				personelDepartmantxt.Visible = true;
				personelNo.Visible = true;
				personelNotxt.Visible = true;

				personelEklebtn.Visible = true;
				personelGuncellebtn.Visible = true;
				personelSilbtn.Visible = true;

				yoneticitxt.Visible = false;
				yoneticiAd.Visible = false;
				yoneticiAditxt.Visible = false;
				yoneticiSoyad.Visible = false;
				yoneticiSoyaditxt.Visible = false;
				yoneticiDepartman.Visible = false;
				yoneticiDepartmantxt.Visible = false;
				yoneticiNo.Visible = false;
				yoneticiNotxt.Visible = false;

				yoneticiEklebtn.Visible = false;
				yoneticiGuncellebtn.Visible = false;
				yoneticiSilbtn.Visible = false;

			}
			else if (secilenSecenek == "Yönetici")
			{
				personeltxt.Visible = false;
				personelAd.Visible = false;
				personelAdtxt.Visible = false;
				personelSoyad.Visible = false;
				personelSoyadtxt.Visible = false;
				personelDepartman.Visible = false;
				personelDepartmantxt.Visible = false;
				personelNo.Visible = false;
				personelNotxt.Visible = false;

				personelEklebtn.Visible = false;
				personelGuncellebtn.Visible = false;
				personelSilbtn.Visible = false;



				yoneticitxt.Visible = true;
				yoneticiAd.Visible = true;
				yoneticiAditxt.Visible = true;
				yoneticiSoyad.Visible = true;
				yoneticiSoyaditxt.Visible = true;
				yoneticiDepartman.Visible = true;
				yoneticiDepartmantxt.Visible = true;
				yoneticiNo.Visible = true;
				yoneticiNotxt.Visible = true;
				yoneticiSifreTxt.Visible = true;
				yoneticiSifre.Visible= true;
				yoneticiMailTxt.Visible = true;
				yoneticiMail.Visible = true;


				yoneticiEklebtn.Visible = true;
				yoneticiGuncellebtn.Visible = true;
				yoneticiSilbtn.Visible = true;
			}
			else
			{

			}
			
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void stajyerNo_TextChanged(object sender, EventArgs e)
		{

		}

		private void stajyerDepartman_TextChanged(object sender, EventArgs e)
		{

		}

		private void stajyerSoyad_TextChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void stajyerAd_TextChanged(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void yoneticiEklebtn_Click(object sender, EventArgs e)
		{
			baglanti.Open();


			string sorgu1 = "SELECT COUNT(*) FROM Yonetici WHERE yoneticiNo = @yoneticiNo";
			SqlCommand komut = new SqlCommand(sorgu1, baglanti);
			komut.Parameters.AddWithValue("@yoneticiNo", yoneticiNo.Text);
			int rowCount = (int)komut.ExecuteScalar();

			if (rowCount == 0)
			{
				string sorgu = "INSERT INTO Yonetici(yoneticiAd,yoneticiSoyad,departmanID,yoneticiNo,yoneticiSifre,yoneticiEposta)" +
				"values (@yoneticiAd,@yoneticiSoyad,@departmanID,@yoneticiNo,@yoneticiSifre,@yoneticiEposta)";
				komut = new SqlCommand(sorgu, baglanti);
				komut.Parameters.AddWithValue("@yoneticiAd", yoneticiAd.Text);
				komut.Parameters.AddWithValue("@yoneticiSoyad", yoneticiSoyad.Text);
				komut.Parameters.AddWithValue("@departmanID", yoneticiDepartman.Text);
				komut.Parameters.AddWithValue("@yoneticiNo", yoneticiNo.Text);
				komut.Parameters.AddWithValue("@yoneticiSifre", yoneticiSifre.Text);
				komut.Parameters.AddWithValue("@yoneticiEposta", yoneticiMail.Text);


				komut.ExecuteNonQuery();

				MessageBox.Show("Yönetici Kaydedildi!");
			}
			else
			{
				MessageBox.Show("Bir Hata Oluştu. Lütfen Tekrar Deneyin.");
			}
			baglanti.Close();
		}

		private void yoneticiGuncellebtn_Click(object sender, EventArgs e)
		{
			baglanti.Open();


			string sorgu1 = "SELECT COUNT(*) FROM Yonetici WHERE yoneticiNo = @yoneticiNo";
			SqlCommand komut = new SqlCommand(sorgu1, baglanti);
			komut.Parameters.AddWithValue("@yoneticiNo", yoneticiNo.Text);
			int rowCount = (int)komut.ExecuteScalar();

			if (rowCount != 0)
			{
				string sorgu = "UPDATE Yonetici SET yoneticiAd = @yoneticiAd, yoneticiSoyad = @yoneticiSoyad, departmanID = @departmanID, " +
							   "yoneticiNo = @yoneticiNo, yoneticiSifre = @yoneticiSifre, yoneticiEposta = @yoneticiEposta" +
							   " WHERE yoneticiNo = @yoneticiNo";
				komut = new SqlCommand(sorgu, baglanti);
				komut.Parameters.AddWithValue("@yoneticiAd", yoneticiAd.Text);
				komut.Parameters.AddWithValue("@yoneticiSoyad", yoneticiSoyad.Text);
				komut.Parameters.AddWithValue("@departmanID", yoneticiDepartman.Text);
				komut.Parameters.AddWithValue("@yoneticiNo", yoneticiNo.Text);
				komut.Parameters.AddWithValue("@yoneticiSifre", yoneticiSifre.Text);
				komut.Parameters.AddWithValue("@yoneticiEposta", yoneticiMail.Text);


				komut.ExecuteNonQuery();

				MessageBox.Show("Yönetici Bilgileri Güncellendi!");
			}
			else
			{
				MessageBox.Show("Bu yönetici numarasına sahip bir kayıt bulunamadı.");
			}
			baglanti.Close();
		}

		private void yoneticiSilbtn_Click(object sender, EventArgs e)
		{
			baglanti.Open();

			string sorgu1 = "SELECT COUNT(*) FROM Yonetici WHERE yoneticiNo = @yoneticiNo";
			SqlCommand komut = new SqlCommand(sorgu1, baglanti);
			komut.Parameters.AddWithValue("@yoneticiNo", yoneticiNo.Text);
			int rowCount = (int)komut.ExecuteScalar();

			if (rowCount > 0)
			{
				string sorgu = "DELETE FROM Yonetici WHERE yoneticiNo = @yoneticiNo";
				komut = new SqlCommand(sorgu, baglanti);
				komut.Parameters.AddWithValue("@yoneticiNo", yoneticiNo.Text);

				komut.ExecuteNonQuery();

				MessageBox.Show("Yönetici Silindi!");
			}
			else
			{
				MessageBox.Show("Bu yönetici numarasına sahip bir kayıt bulunamadı.");
			}
			baglanti.Close();
		}
	}
}
