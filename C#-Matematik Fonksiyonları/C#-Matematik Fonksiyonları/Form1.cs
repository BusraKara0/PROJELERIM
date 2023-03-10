using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Matematik_Fonksiyonları
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Double sayi = Convert.ToDouble(textBox1.Text);
			label2.Text = Math.Abs(sayi).ToString();
			label3.Text = Math.Ceiling(sayi).ToString();
			label4.Text = Math.Floor(sayi).ToString();
			label5.Text = Math.Pow(sayi,3).ToString();
			label6.Text = Math.Sqrt(sayi).ToString();
			label7.Text = Math.PI.ToString();
		}
	}

	/*
	 * sqrt = karekök
	 * pow = üs
	 * abs = mutlak
	 * ceil = üste yuvarlama
	 * floor = alta yuvarlama
	 */
}
