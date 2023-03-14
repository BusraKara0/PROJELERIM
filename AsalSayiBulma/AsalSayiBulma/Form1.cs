namespace AsalSayiBulma
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			int sayac = 0;
			int sayi = Convert.ToInt16(textBox1.Text);
			for(int i = 2; i < sayi; i++)
			{
				if (sayi % i == 0)
					sayac++;
			}
			if(sayac != 0)
			{
				textBox2.Text = "Sayý Asal Deðil";
			}
			else
			{
				textBox2.Text = "Sayý Asal";
			}
		}
	}
}