using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_IV
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int s, x;
		private void button1_Click(object sender, EventArgs e)
		{
			s = Convert.ToInt16(textBox1.Text);
			x = (s * 18) / 100;
			label2.Text = x.ToString();
		}
	}
}
