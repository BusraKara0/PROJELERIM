namespace C__Dizi_Tanımlama_ve_Eleman_Yazdırma
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string[] kisiler = { "Büşra", "Dilara", "Egem", "Ayşe", "Gülben", "Fatma" };
			label1.Text = kisiler[5];
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int[] sayilar = { 5, 9, 6, 7, 3, 2, 0 };
			label2.Text = sayilar[6].ToString();
		}
	}
}