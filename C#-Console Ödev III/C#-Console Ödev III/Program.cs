using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Ödev_III
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string blg;
			Console.Write("Ad - Soyad - Yaş - Meslek");
			blg = Console.ReadLine();
			Kisi ks = new Kisi("Büşra - KARA - 19 - Öğrenci");
			Console.Read();
		}
	}
}
