namespace Visual_Basic_Ödev_1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			listBox1.Items.Add(textBox1.Text + "Ad:" + textBox2.Text + "Soyad:" + textBox3.Text + "Yaş:" + textBox4.Text + "Meslek:")
		}
	}
}