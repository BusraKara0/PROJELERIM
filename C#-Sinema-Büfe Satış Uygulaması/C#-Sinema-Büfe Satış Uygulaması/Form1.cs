namespace C__Sinema_Büfe_Satış_Uygulaması
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int kasatutar = 0;
		private void button1_Click(object sender, EventArgs e)
		{
			int misir, su, cay, bilet, toplam;
			misir = Convert.ToInt16(TxtMisir.Text);
			su = Convert.ToInt16(TxtSu.Text);
			cay = Convert.ToInt16(TxtCay.Text);
			bilet = Convert.ToInt16(TxtBilet.Text);
			toplam = misir * 4 + su * 1 + cay * 2 + bilet * 8;
			LblToplam.Text = toplam.ToString() + "TL";
			kasatutar = kasatutar + toplam;
			LblKasa.Text = kasatutar.ToString() + "TL";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			TxtBilet.Text = "";
			TxtCay.Text = "";
			TxtMisir.Text = "";
			TxtSu.Text = "";
			TxtMisir.Focus();
		}
	}
}