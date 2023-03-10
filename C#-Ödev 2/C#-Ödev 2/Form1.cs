namespace C__Ödev_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int uzunkenar, kısakenar, alan, cevre;
			uzunkenar = 20;
			kısakenar = 10;
			alan = uzunkenar * kısakenar;
			cevre = uzunkenar + uzunkenar + kısakenar + kısakenar;
			label1.Text = "Alan:" + alan + " " + "Çevre:" + cevre;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int not1, not2, not3, ort;
			not1 = Convert.ToInt16(textBox1.Text);
			not2 = Convert.ToInt16(textBox2.Text);
			not3 = Convert.ToInt16(textBox3.Text);
			ort = (not1 + not2 + not3) / 3;
			textBox4.Text = ort.ToString();
		}
	}
}