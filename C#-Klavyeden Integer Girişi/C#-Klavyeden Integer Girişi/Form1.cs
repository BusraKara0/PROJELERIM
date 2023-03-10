namespace C__Klavyeden_Integer_Girişi
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
			sayi = Convert.ToInt16(textBox1.Text);
			label2.Text = sayi.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int sayi, sonuc;
			sayi1 = Convert.ToInt16(textBox2.Text);
			sonuc = sayi * sayi * sayi;
			label4.Text = sonuc.ToString();
		}
	}
}