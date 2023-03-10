namespace C__Ödev_5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int yaricap, alan, cevre, pi;
			yaricap = 15;
			pi = 3;
			alan = pi * yaricap * yaricap;
			cevre = 2 * pi * yaricap;
			label1.Text = "Alan:" + alan + " " + "Çevre:" + cevre;
		}
	}
}