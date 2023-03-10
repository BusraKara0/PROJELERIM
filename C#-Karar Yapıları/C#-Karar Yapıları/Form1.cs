namespace C__Karar_Yapıları
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "Ali")
			{
				label1.Text = "Doğru";
			}
			else
			{
				label1.Text = "Yanlış";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int sayi = Convert.ToInt16(textBox2.Text);
			if (sayi == 5)
			{
				label2.Text = "Doğru";
			}
			else
			{
				label2.Text = "Yanlış";
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int sayi = Convert.ToInt16(textBox3.Text);
			if (sayi % 2 == 0)
			{
				label3.Text = "Çift";
			}
			else
			{
				label3.Text = "Tek";
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int sayi = Convert.ToInt16(textBox4.Text);
			if (sayi % 2 == 0 && sayi >= 10)
			{
				label4.Text = "10'dan büyük veya Çift";
			}
			else
			{
				label4.Text = "10'dan büyük değil veya Çift değil.";
			}
		}
	}
}