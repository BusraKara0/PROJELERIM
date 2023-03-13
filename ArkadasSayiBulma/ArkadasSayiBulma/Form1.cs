namespace ArkadasSayiBulma
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int sayi1, sayi2;
		private void button1_Click(object sender, EventArgs e)
		{
			int sayi1 = Convert.ToInt16(textBox1.Text);
			int sayi2 = Convert.ToInt16(textBox2.Text);
			int birincitoplam = 0;
			int ikincitoplam = 0;
			for(int i = 1; i<sayi1; i++)
			{
				if (sayi1 % i == 0)
				{
					birincitoplam += i;
				}
			}
			for (int i = 1; i < sayi2; i++)
			{
				if(sayi2 % i == 0)
				{
					ikincitoplam += i;
				}
			}
			if (sayi1 == ikincitoplam && sayi2 == birincitoplam)
			{
				textBox3.Text = "Arkadaþ Sayýlar.";
			}
			else
			{
				textBox3.Text = "Arkadaþ Sayý Deðiller.";
			}
		}
	}
}