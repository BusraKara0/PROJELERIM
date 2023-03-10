namespace C__Ondalıklı_Dizi__Ödev_9_
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Double[] ondaliklisayilar = { 0.5, 3.9, 5.7, 6.7 };
			label1.Text = ondaliklisayilar[2].ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string[] harfler = { "B", "Ş", "R", "E", "D", "L", "M" };
			for(int i = 0; i < harfler.Length; i++)
			{
				listBox1.Items.Add(harfler[i]);
			}
		}
	}
}