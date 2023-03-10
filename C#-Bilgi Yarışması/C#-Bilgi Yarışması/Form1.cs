using System.Diagnostics.Eventing.Reader;

namespace C__Bilgi_Yarışması
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int soruno = 0, dogru = 0, yanlis = 0;
		private void btnSonraki_Click(object sender, EventArgs e)
		{

			btnA.Enabled = true;
			btnB.Enabled = true;
			btnC.Enabled = true;
			btnD.Enabled = true;
			btnSonraki.Enabled = false;

			pictureBox1.Visible = false;
			pictureBox2.Visible = false;

			soruno++;
			lblSoruno.Text = soruno.ToString();

			if (soruno == 1)
			{
				richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
				btnA.Text = "1920";
				btnB.Text = "1921";
				btnC.Text = "1922";
				btnD.Text = "1923";
				label4.Text = "1923";
			}

			if (soruno == 2)
			{
				richTextBox1.Text = "Hangi il Ege bölgemizde bulunmaz?";
				btnA.Text = "İzmir";
				btnB.Text = "Balıkesir";
				btnC.Text = "Aydın";
				btnD.Text = "Manisa";
				label4.Text = "Balıkesir";
			}

			if (soruno == 3)
			{
				richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir?";
				btnA.Text = "Sait Faik";
				btnB.Text = "Cemal Süreya";
				btnC.Text = "Attila İlhan";
				btnD.Text = "Reşat Nuri";
				label4.Text = "Sait Faik";
				btnSonraki.Text = "Sonuçlar";
			}
			if (soruno == 4)
			{
				btnA.Enabled = false;
				btnB.Enabled = false;
				btnC.Enabled = false;
				btnD.Enabled = false;
				btnSonraki.Enabled = false;
				MessageBox.Show("Doğru:" + dogru + "\n" + "Yanlış:" + yanlis);
			}
		}

		private void btnA_Click(object sender, EventArgs e)
		{
			btnA.Enabled = false;
			btnB.Enabled = false;
			btnC.Enabled = false;
			btnD.Enabled = false;
			btnSonraki.Enabled = true;

			label5.Text = btnA.Text;
			if (label4.Text == label5.Text)
			{
				dogru++;
				lblDogru.Text = dogru.ToString();
				pictureBox1.Visible = true;
			}
			else
			{
				yanlis++;
				lblYanlis.Text = yanlis.ToString();
				pictureBox2.Visible = true;
			}
		}

		private void btnB_Click(object sender, EventArgs e)
		{
			btnA.Enabled = false;
			btnB.Enabled = false;
			btnC.Enabled = false;
			btnD.Enabled = false;
			btnSonraki.Enabled = true;

			label5.Text = btnB.Text;
			if (label4.Text == label5.Text)
			{
				dogru++;
				lblDogru.Text = dogru.ToString();
				pictureBox1.Visible = true;
			}
			else
			{
				yanlis++;
				lblYanlis.Text = yanlis.ToString();
				pictureBox2.Visible = true;
			}
		}

		private void btnC_Click(object sender, EventArgs e)
		{
			btnA.Enabled = false;
			btnB.Enabled = false;
			btnC.Enabled = false;
			btnD.Enabled = false;
			btnSonraki.Enabled = true;

			label5.Text = btnC.Text;
			if (label4.Text == label5.Text)
			{
				dogru++;
				lblDogru.Text = dogru.ToString();
				pictureBox1.Visible = true;
			}
			else
			{
				yanlis++;
				lblYanlis.Text = yanlis.ToString();
				pictureBox2.Visible = true;
			}
		}

		private void btnD_Click(object sender, EventArgs e)
		{
			btnA.Enabled = false;
			btnB.Enabled = false;
			btnC.Enabled = false;
			btnD.Enabled = false;
			btnSonraki.Enabled = true;

			label5.Text = btnD.Text;
			if (label4.Text == label5.Text)
			{
				dogru++;
				lblDogru.Text = dogru.ToString();
				pictureBox1.Visible = true;
			}
			else
			{
				yanlis++;
				lblYanlis.Text = yanlis.ToString();
				pictureBox2.Visible = true;
			}
		}
	}
}