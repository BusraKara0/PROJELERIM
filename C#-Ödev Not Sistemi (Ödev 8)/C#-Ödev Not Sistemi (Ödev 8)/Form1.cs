namespace C__Ödev_Not_Sistemi__Ödev_8_
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double vize, final, ortalama;
			vize = Convert.ToDouble(textBox3.Text);
			final = Convert.ToDouble(textBox4.Text);
			ortalama = (vize + final) / 2;
			textBox5.Text = ortalama.ToString();
			if (ortalama < 45)
			{
				label7.Text = "FF";
			}
			if (ortalama>45 && ortalama<=55)
			{
				label7.Text = "DD";
			}
			if (ortalama > 55 && ortalama<=60)
			{
				label7.Text = "DC";
			}
			if (ortalama>60 && ortalama<=75)
			{
				label7.Text = "BB";
			}
			if (ortalama >75 && ortalama <= 100)
			{
				label7.Text = "AA";
			}
			listBox1.Items.Add(textBox1.Text);
			listBox1.Items.Add(textBox2.Text);
			listBox1.Items.Add(label7.Text);
			// Elime Koluma Sağlık Kolay Gelsin :):
		}
	}
}