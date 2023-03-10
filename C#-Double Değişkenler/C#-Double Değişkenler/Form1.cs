namespace C__Double_Değişkenler
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double sayi;
			sayi = 4.25;
			label1.Text = sayi.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			double s1, s2, s3, ort;
			s1 = 60;
			s2 = 70;
			s3 = 79;
			ort = (s1 + s2 + s3) / 3;
			label2.Text = ort.ToString("0.00");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			double sayi = Convert.ToDouble(textBox1.Text);
			label3.Text = sayi.ToString();
		}
	}
}