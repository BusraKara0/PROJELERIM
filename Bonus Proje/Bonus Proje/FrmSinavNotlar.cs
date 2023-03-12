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

namespace Bonus_Proje
{
	public partial class FrmSinavNotlar : Form
	{
		public FrmSinavNotlar()
		{
			InitializeComponent();
		}

		DataSet1TableAdapters.TBLNOTLARTableAdapter ds = new DataSet1TableAdapters.TBLNOTLARTableAdapter();

		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BMF26BV;Initial Catalog=BonusOkul;Integrated Security=True");

		private void btnara_Click(object sender, EventArgs e)
		{
			dataGridView2.DataSource = ds.NotListesi(int.Parse(txtid.Text));
		}

		private void FrmSinavNotlar_Load(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("Select * From TBLDERSLER", baglanti);
			SqlDataAdapter da = new SqlDataAdapter(komut);
			DataTable dt = new DataTable();
			da.Fill(dt);
			ComboBox1.DisplayMember = "DERSAD";
			ComboBox1.ValueMember = "DERSID";
			ComboBox1.DataSource = dt;
			baglanti.Close();
		}
		int notid;
		private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			notid = int.Parse (dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
			txtid.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
			TxtSinav1.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
			TxtSinav2.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
			TxtSinav3.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
			TxtProje.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
			TxtOrtalama.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
			TxtDurum.Text = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();
		}
		int sinav1, sinav2, sinav3, proje;
		double ortalama;
		private void BtnHesapla_Click(object sender, EventArgs e)
		{
			
			//string durum;
			sinav1 = Convert.ToInt16(TxtSinav1.Text);
			sinav2 = Convert.ToInt16(TxtSinav2.Text);
			sinav3 = Convert.ToInt16(TxtSinav3.Text);
			proje = Convert.ToInt16(TxtProje.Text);
			ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
			TxtOrtalama.Text = ortalama.ToString();
			if (ortalama <= 50)
			{
				TxtDurum.Text = "True";
			}
			else
			{
				TxtDurum.Text = "False";
			}
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			ds.NotGuncelle(byte.Parse(ComboBox1.SelectedValue.ToString()), int.Parse(txtid.Text), byte.Parse(TxtSinav1.Text),byte.Parse (TxtSinav2.Text),byte.Parse (TxtSinav3.Text),byte.Parse (TxtProje.Text),decimal.Parse (TxtOrtalama.Text), bool.Parse(TxtDurum.Text), notid);		}
	}
}
