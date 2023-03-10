namespace C__Timer_Kullanımı
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int sayac = 0;
		private void button1_Click(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			sayac++;
			label1.Text = sayac.ToString();
			if (sayac == 5) 
			{
				this.BackColor = Color.DarkRed;
			}
			if (sayac == 10)
			{
				this.BackColor = Color.DarkBlue;
				sayac = 0;
			}
		}
	}
}