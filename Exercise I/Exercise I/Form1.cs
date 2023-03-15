namespace Exercise_I
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		string ad, soyad;
		private void button1_Click(object sender, EventArgs e)
		{
			ad = "Büþra";
			soyad = "KARA";
			textBox1.Text = ad;
			textBox2.Text = soyad;
		}
	}
}