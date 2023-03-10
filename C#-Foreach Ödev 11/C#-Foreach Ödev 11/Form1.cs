namespace C__Foreach_Ödev_11
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int[] sayilar = { 52, 84, 59, 31, 25, 76, 20, 87, 65, 74 };
			foreach (int x in sayilar)
			{
				 if (sayilar[x]/4==0)
				{	
						listBox1.Items.Add(sayilar[x]);
				}
			}
		}
	}
}