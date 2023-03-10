using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Ödev_3
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string urunadı;
			int fiyat, indirim, sonuc;
			urunadı = textBox1.Text;
			fiyat = Convert.ToInt16(textBox2.Text);
			indirim = Convert.ToInt16(textBox3.Text);
			sonuc = (fiyat * 8) / 100;
			listBox1.Items.Add(urunadı + " " + fiyat + "KDV:" + sonuc);
		}
	}
}
