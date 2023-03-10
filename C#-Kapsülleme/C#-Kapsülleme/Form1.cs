namespace C__Kapsülleme
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Arabam rb3 = new Arabam();
			rb3.renk = "Mavi";
			rb3.hiz = 160;
			rb3.motor = 1245.56;
			rb3.fiyat = 50000;
			rb3.durum = 's';
			rb3.YIL = -2022;
			rb3.MARKASI = "Golf";

			label1.Text = rb3.renk;
			label2.Text = rb3.hiz.ToString();
			label3.Text = rb3.motor.ToString();
			label4.Text = rb3.fiyat.ToString();
			label5.Text = rb3.durum.ToString();
			label6.Text = rb3.YIL.ToString();
			label7.Text = rb3.MARKASI ;
			pictureBox1.BackColor = Color.AliceBlue;
		}
	}
}