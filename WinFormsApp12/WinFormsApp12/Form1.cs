namespace WinFormsApp12
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String metin;
			metin = "Merhaba Bug�n 24 �ubat 2023 Cuma";
			label1.Text = metin;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			String adsoyad, meslek;
			adsoyad = "B��ra KARA";
			meslek = "��renci";
			label2.Text = adsoyad;
			label3.Text = meslek;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			String sehir;
			sehir = textBox1.Text;
			label4.Text = sehir;
		}
	}
}