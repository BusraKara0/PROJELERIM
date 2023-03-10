namespace C__Kalıtım
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Arabag rb3 = new Arabag();
			rb3.renk = "Mavi";
			rb3.hiz = 160;
			rb3.motor = 1245.56;
			rb3.fiyat = 50000;
			rb3.durum = 's';
			rb3.YIL = -2022;
			rb3.MARKASI = "Golf";
			rb3.muayene = 2020;
			rb3.plaka = "34 Aİ 1881";
			rb3.sahip = "Zübeyde Hanım";

			label1.Text = rb3.renk;
			label2.Text = rb3.hiz.ToString();
			label3.Text = rb3.motor.ToString();
			label4.Text = rb3.fiyat.ToString();
			label5.Text = rb3.durum.ToString();
			label6.Text = rb3.YIL.ToString();
			label7.Text = rb3.MARKASI;
			pictureBox1.BackColor = Color.AliceBlue;

			label8.Text = rb3.muayene.ToString();
			label9.Text = rb3.plaka;
			label10.Text = rb3.sahip;
		}
	}
}