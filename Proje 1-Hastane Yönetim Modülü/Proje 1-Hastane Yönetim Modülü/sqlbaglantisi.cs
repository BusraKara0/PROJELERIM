using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_1_Hastane_Yönetim_Modülü
{
	internal class sqlbaglantisi
	{
		public SqlConnection baglanti()
		{
			SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMF26BV;Initial Catalog=HastaneProje;Integrated Security=True");
			baglan.Open();
			return baglan;
		}
	}
}
