namespace C__Döngüler
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int i;
			for (i = 1; i <= 10; i++)
			{
				listBox1.Items.Add(i + "Merhaba Ankara");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			for (int i = 1; i < 11; i++)
			{
				listBox2.Items.Add(i);
			}
		}
	}
}