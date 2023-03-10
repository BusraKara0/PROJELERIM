using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace C__Bilgi_Yarışması_1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int soruno = 0, dogru = 0, yanlis = 0;
		private void BtnSonraki_Click(object sender, EventArgs e)
		{
			BtnA.Enabled = true;
			BtnB.Enabled = true;
			BtnC.Enabled = true;
			BtnD.Enabled = true;
			BtnSonraki.Enabled = false;

			pictureBox1.Visible = false;
			pictureBox2.Visible = false;

			soruno++;
			LblSoruno.Text = soruno.ToString();

			if (soruno == 1)
			{
				richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
				BtnA.Text = "1920";
				BtnB.Text = "1921";
				BtnC.Text = "1922";
				BtnD.Text = "1923";
				label4.Text = "1923";
			}
			if (soruno == 2)
			{
				richTextBox1.Text = "Hangi il Ege bölgemizde bulunmaz?";
				BtnA.Text = "İzmir";
				BtnB.Text = "Balıkesir";
				BtnC.Text = "Aydın";
				BtnD.Text = "Manisa";
				label4.Text = "Balıkesir";
			}
			if (soruno == 3)
			{
				richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir?";
				BtnA.Text = "Sait Faik";
				BtnB.Text = "Cemal Süreya";
				BtnC.Text = "Attila İlhan";
				BtnD.Text = "Reşat Nuri";
				label4.Text = "Sait Faik";
				BtnSonraki.Text = "Sonuçlar";
			}
			if (soruno == 4)
			{
				BtnA.Enabled = false;
				BtnB.Enabled = false;
				BtnC.Enabled = false;
				BtnD.Enabled = false;
				BtnSonraki.Enabled = false;
				MessageBox.Show("Doğru:" + dogru + "\n" + "Yanlış:" + yanlis);
			}
		}

		private void BtnA_Click(object sender, EventArgs e)
		{
			BtnA.Enabled = false;
			BtnB.Enabled = false;
			BtnC.Enabled = false;
			BtnD.Enabled = false;
			BtnSonraki.Enabled = true;

			label5.Text = BtnA.Text;
			if (label4.Text == label5.Text)
			{
				dogru++;
				LblDogru.Text = dogru.ToString();
				pictureBox1.Visible = true;
			}
			else
			{
				yanlis++;
				LblYanlis.Text = yanlis.ToString();
				pictureBox2.Visible = true;
			}
		}

		private void BtnB_Click(object sender, EventArgs e)
		{
			BtnA.Enabled = false;
			BtnB.Enabled = false;
			BtnC.Enabled = false;
			BtnD.Enabled = false;
			BtnSonraki.Enabled = true;

			label5.Text = BtnB.Text;
			if (label4.Text == label5.Text)
			{
				dogru++;
				LblDogru.Text = dogru.ToString();
				pictureBox1.Visible = true;
			}
			else
			{
				yanlis++;
				LblYanlis.Text = yanlis.ToString();
				pictureBox2.Visible = true;
			}
		}

		private void BtnC_Click(object sender, EventArgs e)
		{
			BtnA.Enabled = false;
			BtnB.Enabled = false;
			BtnC.Enabled = false;
			BtnD.Enabled = false;
			BtnSonraki.Enabled = true;

			label5.Text = BtnC.Text;
			if (label4.Text == label5.Text)
			{
				dogru++;
				LblDogru.Text = dogru.ToString();
				pictureBox1.Visible = true;
			}
			else
			{
				yanlis++;
				LblYanlis.Text = yanlis.ToString();
				pictureBox2.Visible = true;
			}
		}

		private void BtnD_Click(object sender, EventArgs e)
		{
			BtnA.Enabled = false;
			BtnB.Enabled = false;
			BtnC.Enabled = false;
			BtnD.Enabled = false;
			BtnSonraki.Enabled = true;

			label5.Text = BtnD.Text;
			if (label4.Text == label5.Text)
			{
				dogru++;
				LblDogru.Text = dogru.ToString();
				pictureBox1.Visible = true;
			}
			else
			{
				yanlis++;
				LblYanlis.Text = yanlis.ToString();
				pictureBox2.Visible = true;
			}
		}
	}
}