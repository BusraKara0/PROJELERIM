using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Ödev_II
{
	internal class Islem
	{ 
		public int topla(int x, int y)
		{
			int z = x + y;
			Console.WriteLine("Birinci Sayıyı Girin:");
			Console.WriteLine(x);
			Console.WriteLine("İkinci Sayıyı Girin:");
			Console.WriteLine(y);
			Console.WriteLine("Sonuç:");
			Console.WriteLine(z);
			return z;
		}
	}
}
