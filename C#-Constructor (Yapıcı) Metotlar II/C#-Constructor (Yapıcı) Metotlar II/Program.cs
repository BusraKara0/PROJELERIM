using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Constructor__Yapıcı__Metotlar_II
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Kimlik kml = new Kimlik();
			kml.AD = "Büşra";
			kml.SOYAD = "KARA";
			kml.MEMLEKET = "Adana";
			Console.WriteLine(kml.AD);
			Console.WriteLine(kml.SOYAD);
			Console.WriteLine(kml.MEMLEKET);
			Console.WriteLine(kml.YAS);
			Console.WriteLine(kml.CINSIYET);
			Console.Read();
		}
	}
}
