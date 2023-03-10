namespace C__Ödev_6
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		
		private void button1_Click(object sender, EventArgs e)
		{
			int sayi;
			int sonuc = 1;
			sayi = Convert.ToInt16(textBox1.Text);
			for (int i = 1; i <= sayi; i++)
			{
				sonuc = sonuc * i;
			}
			listBox1.Items.Add(sonuc);
		}
	}
}