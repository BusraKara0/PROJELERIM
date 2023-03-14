namespace AsalSayiiOdevii
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			int s = 0; 
			int sayi = Convert.ToInt16(textBox1.Text);
			for(int i = 2; i < sayi; i++)
			{
				if (sayi % i == 0)
				{
					s++;
					break;

				}
			}
			if(s == 0)
			{
				textBox2.Text = "Sayý Asaldýr.";
			}
			else
			{
				textBox2.Text = "Sayý Asal Deðildir.";
			}
		}
	}
}