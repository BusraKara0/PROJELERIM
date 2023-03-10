namespace C__Ödev_4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int sayi1, sayi2, sayi3, toplam, carpim, fark;
			sayi1 = Convert.ToInt16(textBox1.Text);
			sayi2 = Convert.ToInt16(textBox2.Text);
			sayi3 = Convert.ToInt16(textBox3.Text);
			toplam = sayi1 + sayi2 + sayi3;
			carpim = sayi1 * sayi2 * sayi3;
			fark = sayi1 - sayi2 - sayi3;
			MessageBox.Show("Toplam:" + toplam + "\n" + "Çarpım:" + carpim + "\n" + "Fark" + fark);
		}
	}
}