namespace C__Döngüler_Pratik
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int toplam = 0;
			for (int i = 1; i <= 10; i++)
			{
				toplam = toplam + i;
			}
			label1.Text = toplam.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int toplam = 0;
			for (int i = 2; i <= 10; i += 2)
			{
				toplam = toplam + i;
			}
			label3.Text = toplam.ToString();
		}
	}
}