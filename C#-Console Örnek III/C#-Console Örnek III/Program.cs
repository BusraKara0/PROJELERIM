using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Örnek_III
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Kisiler ks = new Kisiler();
			ks.kisilistesi("Büşra KARA");
			ks.kisilistesi("Ramazan KARA");
			Console.Read();
		}
	}
}
