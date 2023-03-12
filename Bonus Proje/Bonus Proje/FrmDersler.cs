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
	public partial class FrmDersler : Form
	{
		public FrmDersler()
		{
			InitializeComponent();
		}
		DataSet1TableAdapters.TBLDERSLERTableAdapter ds = new DataSet1TableAdapters.TBLDERSLERTableAdapter();
		private void FrmDersler_Load(object sender, EventArgs e)
		{
			
			dataGridView1.DataSource = ds.DersListesi();
		}

		private void btnekle_Click(object sender, EventArgs e)
		{
			ds.DersEkle(txtdersadı.Text);
			MessageBox.Show("Ders Ekleme İşlemi Yapılmıştır.");
		}

		private void btnlistele_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = ds.DersListesi();
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void btnsil_Click(object sender, EventArgs e)
		{
			ds.DersSil(byte.Parse(txtdersid.Text));

		}

		private void btnguncelle_Click(object sender, EventArgs e)
		{
			ds.DersGuncelle(txtdersadı.Text,byte.Parse(txtdersid.Text));
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtdersid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtdersadı.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
		}


	}
}
