namespace AsalSayiiOdevii
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int sayi;
		private void button1_Click(object sender, EventArgs e)
		{
			int sayi = Convert.ToInt16(textBox1.Text);
			if (sayi % 2 == 0)
			{
				textBox2.Text = "Girdi�iniz Say� Asal De�ildir.";
			}
			else
			{
				textBox2.Text = "Girdi�iniz Say� Asald�r.";
			}
		}
	}
}