using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Veri_Taşıma_Ödev
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 fm = new Form2();
			fm.ad = textBox1.Text;
			fm.soyad = textBox2.Text;
			fm.meslek = textBox3.Text;
			fm.Show();
			this.Hide();
		}
	}
}
