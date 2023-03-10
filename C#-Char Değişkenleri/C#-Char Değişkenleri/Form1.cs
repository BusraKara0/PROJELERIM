namespace C__Char_Değişkenleri
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			char takim;
			takim = 'b';
			label1.Text = takim.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			char ders;
			ders = Convert.ToChar(textBox1.Text);
			label2.Text = ders.ToString();
		}
	}
}