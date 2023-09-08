using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Staj_Takip_Sistemi
{
	public partial class stajyerBilgi : Form
	{
		public stajyerBilgi()
		{
			InitializeComponent();
		}
		SqlDataAdapter da;
		SqlConnection con;
		SqlCommand cmd;
		SqlDataReader dr;
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4UEBQES\\SQLEXPRESS;Initial Catalog=StajProje;Integrated Security=True");

		private void exitBtn_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit(); //ekranda sağ üstteki çarpı butonuna basınca ekranı kapatma kodu

		}

		private void minimizeBtn_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized; //ekranda sağ üstte eksi butonuna basınca ekranı alt sekmeye alma kodu
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			personelPanel pPanel = new personelPanel();
			pPanel.Show();
			this.Hide();
		}

		private void pictureBox3_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(pictureBox3, "Geri");
		}

		private void minimizeBtn_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(minimizeBtn, "Küçült");
		}

		private void exitBtn_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(exitBtn, "Kapat");
		}

		private void stajyerBilgi_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'stajProjeDataSet.Stajyer' table. You can move, or remove it, as needed.
			this.stajyerTableAdapter.Fill(this.stajProjeDataSet.Stajyer);
			// TODO: This line of code loads data into the 'stajProjeDataSet.Yonetici' table. You can move, or remove it, as needed.
			this.yoneticiTableAdapter.Fill(this.stajProjeDataSet.Yonetici);
			// TODO: This line of code loads data into the 'stajProjeDataSet.Departman' table. You can move, or remove it, as needed.
			this.departmanTableAdapter.Fill(this.stajProjeDataSet.Departman);

		}

		private void ara_Click(object sender, EventArgs e)
		{

			baglanti.Open();

			try
			{
				

				if (!string.IsNullOrEmpty(stajyerNo.Text)) // Boş değilse devam et
				{
					string sorgu1 = "SELECT COUNT(*) FROM Stajyer WHERE stajyerNo = @sNo";
					SqlCommand komut5 = new SqlCommand(sorgu1, baglanti);
					komut5.Parameters.AddWithValue("@sNo", stajyerNo.Text);
					int rowCount = (int)komut5.ExecuteScalar();

					if (rowCount == 0)
					{
						MessageBox.Show("Bu stajyer numarasında kayıtlı bir stajyer yok.");
					}
					else
					{
						SqlCommand komut = new SqlCommand("SELECT * FROM Stajyer WHERE stajyerNo LIKE '%" + stajyerNo.Text + "%'", baglanti);
						SqlDataAdapter da = new SqlDataAdapter(komut);
						DataSet ds = new DataSet();
						da.Fill(ds);
						dataGridView1.DataSource = ds.Tables[0];
					}
				}
				else
				{
					MessageBox.Show("StajyerNo alanı boş olamaz.");
				}
			}
			catch (Exception ex)
			{
				label3.Visible = true;
				labelError.Visible = false;
				sonuc.Visible = false;
				MessageBox.Show("Hata: " + ex.Message);
			}

			baglanti.Close();

		}

		private void stajyerNo_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
