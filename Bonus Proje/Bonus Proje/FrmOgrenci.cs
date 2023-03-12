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
	public partial class FrmOgrenci : Form
	{
		public FrmOgrenci()
		{
			InitializeComponent();
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BMF26BV;Initial Catalog=BonusOkul;Integrated Security=True");
		DataSet1TableAdapters.TBLOGRENCILERTableAdapter ds = new DataSet1TableAdapters.TBLOGRENCILERTableAdapter();
		private void FrmOgrenci_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = ds.OgrenciListesi();
			baglanti.Open();
			SqlCommand komut = new SqlCommand("Select * From TBLKULUPLER", baglanti);
			SqlDataAdapter da = new SqlDataAdapter(komut);
			DataTable dt = new DataTable();
			da.Fill(dt);
			ComboBox1.DisplayMember = "KULUPAD";
			ComboBox1.ValueMember = "KULUPID";
			ComboBox1.DataSource = dt;
			baglanti.Close();
		}
		string c = "";
		private void btnekle_Click(object sender, EventArgs e)
		{
		
			ds.OgrenciEkle(txtad.Text, txtsoyad.Text, byte.Parse(ComboBox1.SelectedValue.ToString()), c);
			MessageBox.Show("Öğrenci Ekleme Yapıldı.");
		}

		private void btnlistele_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = ds.OgrenciListesi();
		}

		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//txtid.Text = ComboBox1.SelectedValue.ToString();
		}

		private void btnsil_Click(object sender, EventArgs e)
		{
			ds.OgrenciSil(int.Parse(txtid.Text));
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			//ComboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			//txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
		}

		private void btnguncelle_Click(object sender, EventArgs e)
		{
			ds.OgrenciGuncelle(txtad.Text, txtsoyad.Text,byte.Parse (ComboBox1.SelectedValue.ToString()), c,int.Parse (txtid.Text));

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

			if (radioButton1.Checked == true)
			{
				c = "Kız";
			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton2.Checked == true)
			{
				c = "Erkek";
			}
		}

		private void btnara_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = ds.OgrenciGetir(txtara.Text);
		}

		private void FrmOgrenci_Load_1(object sender, EventArgs e)
		{

		}
	}
}
