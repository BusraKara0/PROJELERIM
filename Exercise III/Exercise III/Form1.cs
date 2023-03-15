using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_III
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int s1, s2, toplam, fark, carpim, bolum;
		private void button1_Click(object sender, EventArgs e)
		{
			s1 = 30;
			s2 = 15;
			textBox1.Text = s1.ToString();
			textBox2.Text = s2.ToString();
			toplam = s1 + s2;
			textBox3.Text = toplam.ToString();
			fark = s1 - s2;
			textBox4.Text = fark.ToString();
			carpim = s1 * s2;
			textBox5.Text = carpim.ToString();
			bolum = s1 / s2;
			textBox6.Text = bolum.ToString();
		}
	}
}
