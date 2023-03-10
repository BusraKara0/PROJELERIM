namespace C__Ödev_10
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int[] sayilar = { 15, 9, 35, 75, 5, 3, 20, 95, 11, 10 };
			for (int i = 0; i < sayilar.Length; i++)
			{
				if (sayilar[i] % 2 == 0)
				{
					listBox1.Items.Add(sayilar[i]);
				}
			}
		}
	}
}