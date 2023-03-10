namespace C__Diziler_Foreach
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string[] kisiler = { "Ali", "Ahmet", "Mehmet", "Mesut", "Pýnar", "Berna" };
			foreach (string k in kisiler)
			{
				listBox1.Items.Add(k);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int toplam = 0;
			int[] sinavlar = { 70, 65, 85, 100, 90 };
			foreach (int x in sinavlar)
			{
				listBox2.Items.Add(x);
				toplam = toplam + x;
			}
			label1.Text = toplam.ToString();
			int ortalama = toplam / sinavlar.Length;
			label2.Text = ortalama.ToString();
		}
	}
}