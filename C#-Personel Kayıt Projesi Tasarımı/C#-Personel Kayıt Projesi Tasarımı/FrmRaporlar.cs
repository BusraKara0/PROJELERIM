using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Personel_Kayıt_Projesi_Tasarımı
{
	public partial class FrmRaporlar : Form
	{
		public FrmRaporlar()
		{
			InitializeComponent();
		}

		private void FrmRaporlar_Load(object sender, EventArgs e)
		{

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
