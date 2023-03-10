namespace C__Geriye_Değer_Döndürmeyen_Metotlar
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void temizle()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox1.Focus();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			temizle();
		}
		void renklendir()
		{
			textBox1.BackColor = Color.DarkGoldenrod;
			textBox2.BackColor = Color.DarkKhaki;
			textBox3.BackColor = Color.DarkOliveGreen;
			textBox4.BackColor = Color.DarkRed;
		}
		private void button2_Click(object sender, EventArgs e)
		{
			renklendir();
		}
	}
}