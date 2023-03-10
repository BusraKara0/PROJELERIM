using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Veri_Taşıma_Ödev
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		public string ad;
		public string soyad;
		public string meslek;
		private void Form2_Load(object sender, EventArgs e)
		{
			comboBox1.Text = ad;
			comboBox2.Text = soyad;
			comboBox3.Text = meslek;
		}
	}
}
