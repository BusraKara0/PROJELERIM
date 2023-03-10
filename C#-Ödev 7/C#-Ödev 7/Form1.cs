namespace C__Ödev_7
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
			pictureBox1.Visible = false;
			pictureBox2.Visible = false;
			pictureBox3.Visible = false;
			timer1.Start();
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			sayac++;
			label1.Text = sayac.ToString();
			if (sayac == 10)
			{
				pictureBox1.Visible = true;
				this.BackColor = Color.Green;
			}
			if (sayac == 20)
			{
				pictureBox1.Visible = false;
				pictureBox2.Visible = true;
				this.BackColor = Color.Yellow;
			}
			if (sayac == 30)
			{
				pictureBox2.Visible = false;
				pictureBox3.Visible = true;
				this.BackColor = Color.Red;
			}
			if (sayac == 40)
			{
				pictureBox3.Visible = false;
				sayac = 0;
			}
		}
	}
}