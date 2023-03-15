using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_VI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int b;
		private void button1_Click(object sender, EventArgs e)
		{
			b = Convert.ToInt16(textBox1.Text);
			if(b % 4 == 0 && b % 7 == 0)
			{
				textBox2.Text = "Bu sayı 7 ve 4'ün katı";
			}
			else
			{
				textBox2.Text = "Başka bir sayı girin.";
			}
		}
	}
}
