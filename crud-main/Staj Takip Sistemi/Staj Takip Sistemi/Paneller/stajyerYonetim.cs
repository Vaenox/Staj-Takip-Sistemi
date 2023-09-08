using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj_Takip_Sistemi
{
	public partial class stajyerYonetim :Form 
	{
		public stajyerYonetim()
		{
			InitializeComponent();
		}


		SqlDataAdapter da;
		SqlConnection con;
		SqlCommand cmd;
		SqlDataReader dr;
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4UEBQES\\SQLEXPRESS;Initial Catalog=StajProje;Integrated Security=True");


		private void stajyerYonetim_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'projeData.Stajyer' table. You can move, or remove it, as needed.
            this.stajyerTableAdapter.Fill(this.projeData.Stajyer);

        }

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			yoneticiPanel yPanel = new yoneticiPanel();
			yPanel.Show();
			this.Hide();
		}

		private void exitBtn_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void minimizeBtn_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
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
				
				labelError.Visible = false;
				sonuc.Visible = false;
				MessageBox.Show("Stajyer Numarası sadece sayılardan oluşur!");
			}

			baglanti.Close();

		}
	}
}
