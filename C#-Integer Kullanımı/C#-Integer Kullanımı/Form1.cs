namespace C__Integer_Kullanımı
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int sayi;
			sayi = 24;
			label1.Text = sayi.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int sayi1, sayi2, toplam;
			sayi1 = 5;
			sayi2 = 4;
			toplam = sayi1 + sayi2;
			label2.Text = toplam.ToString();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int kenar, alan, cevre;
			kenar = 10;
			alan = kenar * kenar;
			cevre = kenar * 4;
			label3.Text = " Alan: " + alan + " Çevre: " + cevre;
		}
	}
}