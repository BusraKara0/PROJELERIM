namespace C__Ödevler
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void yazdır()
		{
			textBox1.Text = "Büşra";
			textBox2.Text = "KARA";
			textBox3.Text = "Öğrenci";
			textBox4.Text = "19";
			textBox1.Focus();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			yazdır();
		}
		int carpim(int s1, int s2, int s3)
		{
			int s4 = s1 * s2 * s3;
			return s4;
		}
		private void button2_Click(object sender, EventArgs e)
		{
			label1.Text = carpim(3, 6, 9).ToString();
			label2.Text = carpim(9, 7, 5).ToString();
			label3.Text = carpim(3, 2, 1).ToString();
		}
		int toplam(int s1, int s2)
		{
			int s3 = s1 + s2;
			return s3;
		}
		private void button3_Click(object sender, EventArgs e)
		{
			int s1 = Convert.ToInt16(textBox5.Text);
			int s2 = Convert.ToInt16(textBox6.Text);
			label4.Text = toplam(s1, s2).ToString();
		}
	}
}