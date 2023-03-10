using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Chart_Kullanımı_Pratik
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			chart1.Series["Kitap"].Points.AddXY("Akdeniz Bölgesi", 25);
			chart1.Series["Kitap"].Points.AddXY("Karadeniz Bölgesi", 24);
			chart1.Series["Kitap"].Points.AddXY("Ege Bölgesi", 57);
			chart1.Series["Kitap"].Points.AddXY("Marmara Bölgesi", 32);
			chart1.Series["Kitap"].Points.AddXY("İç Anadolu Bölgesi", 21);
			chart1.Series["Kitap"].Points.AddXY("Doğu Anadolu Bölgesi", 12);
			chart1.Series["Kitap"].Points.AddXY("Güneydoğu Anadolu Bölgesi", 45);
		}
	}
}
