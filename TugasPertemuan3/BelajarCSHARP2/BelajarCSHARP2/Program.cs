/*
 * Created by SharpDevelop.
 * User: LENOVO
 * Date: 23/02/2022
 * Time: 21:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BelajarCSHARP2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Nama kamu siapa?");
			string nama = Console.ReadLine();
			Console.WriteLine("Nama kamu " + nama);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}