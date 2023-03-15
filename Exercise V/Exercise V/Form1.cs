using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_V
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int s1, s2, s3;
		double ort;
		private void button1_Click(object sender, EventArgs e)
		{
			s1 = Convert.ToInt16(textBox1.Text);
			s2 = Convert.ToInt16(textBox2.Text);
			s3 = Convert.ToInt16(textBox3.Text);
			ort = (s1 + s2 + s3) / 3;
			textBox4.Text = ort.ToString();
			if (ort >= 50)
			{
				textBox5.Text = "Geçti";
			}
			else
			{
				textBox5.Text = "Kaldı";
			}
		}
	}
}
