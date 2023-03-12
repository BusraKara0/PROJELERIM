using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bonus_Proje
{
	public partial class FrmKulup : Form
	{
		public FrmKulup()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BMF26BV;Initial Catalog=BonusOkul;Integrated Security=True");
		void liste()
		{
			SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLKULUPLER ", baglanti);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}
		private void FrmKulup_Load(object sender, EventArgs e)
		{
			liste();
		}

		private void btnlistele_Click(object sender, EventArgs e)
		{
			liste();
		}

		private void btnekle_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("INSERT INTO TBLKULUPLER (KULUPAD) VALUES (@P1)", baglanti);
			komut.Parameters.AddWithValue("@P1", txtkulupadı.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Kulüp Listeye Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			liste();
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void pictureBox6_MouseHover(object sender, EventArgs e)
		{
			pictureBox6.BackColor = Color.DarkOrange;
		}

		private void pictureBox6_MouseLeave(object sender, EventArgs e)
		{
			pictureBox6.BackColor = Color.Transparent;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtkulupid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtkulupadı.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
		}

		private void btnsil_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("DELETE FROM TBLKULUPLER WHERE KULUPID=@P1", baglanti);
			komut.Parameters.AddWithValue("@P1", txtkulupid.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Kulüp Silme İşlemi Gerçekleşti.");
			liste();
		}

		private void btnguncelle_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("UPDATE TBLKULUPLER SET KULUPAD=@P1 WHERE KULUPID=@P2", baglanti);
			komut.Parameters.AddWithValue("@P1", txtkulupadı.Text);
			komut.Parameters.AddWithValue("@P2", txtkulupid.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Kulüp Güncelleme İşlemi Gerçekleşti.");
			liste();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
