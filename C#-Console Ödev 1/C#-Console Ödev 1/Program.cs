using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Ödev_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Tanıtım tntm = new Tanıtım();
			string ads;
			Console.WriteLine("İsim Girin: Büşra");
			Console.WriteLine("Soyad Girin: KARA");
			Console.WriteLine("Meslek: Öğrenci");
			Console.WriteLine("Yaş Giriniz: 19");
			ads = Console.ReadLine();
			
			Console.Read();
		}
	}
}
