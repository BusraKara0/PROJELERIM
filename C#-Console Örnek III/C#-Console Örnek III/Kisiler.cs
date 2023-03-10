using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Örnek_III
{
	//Klavyeden girmiş olduğumuz metni ekrana 10 defa yazdır.
	internal class Kisiler
	{
		public void kisilistesi(string adsoyad)
		{
			for (int i=0; i<=10; i++)
			{
				Console.WriteLine(adsoyad);			}
		}
	}
}
