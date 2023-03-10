namespace C__Ödev_1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String ad, soyad, yas, meslek, cinsiyet;
			ad = "Büşra";
			soyad = "KARA";
			yas = "19";
			meslek = "Öğrenci";
			cinsiyet = "Kadın";
			label1.Text = ad;
			label2.Text = soyad;
			label3.Text = yas;
			label4.Text = meslek;
			label5.Text = cinsiyet;
			listBox1.Items.Add(label1.Text + " " + label2.Text + " " + label3.Text + " " + label4.Text + " " + label5.Text);
		}
	}
}