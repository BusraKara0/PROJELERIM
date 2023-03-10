using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Örnek_IV
{
	//Değişken olmasını istersek
	internal class Program
	{
		static void Main(string[] args)
		{
			Kisiler ks = new Kisiler();
			string ads;
			Console.Write("İsim Girin:");
			ads = Console.ReadLine();
			ks.kisilistesi(ads);
			Console.Read();
		}
	}
}
