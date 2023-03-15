namespace Exercise_II
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int s1, s2, sonuc;
		private void button1_Click(object sender, EventArgs e)
		{
			s1 = Convert.ToInt16(textBox1.Text);
			s2 = Convert.ToInt16(textBox2.Text);
			sonuc = s1 + s2;
			textBox3.Text = sonuc.ToString();
		}
	}
}