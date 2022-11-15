using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("<<<尋找區間的質數>>>");

			Console.Write("請輸入區間下限: ");
			string value1 = Console.ReadLine();
			int lower = Convert.ToInt32(value1);

			Console.Write("請輸入區間上限: ");
			string value2 = Console.ReadLine();
			int upper = Convert.ToInt32(value2);

			Console.WriteLine($"{lower}~{upper}質數有: ");

			for (int i = lower; i <= upper; i++)
			{
				if (IsPrime(i))
				{
					Console.Write(i + " ");
				}	
			}
			Console.WriteLine();
		}

		static bool IsPrime(int number)
		{
			if (number == 2) return true;
			int limit = (int)Math.Ceiling(Math.Sqrt(number));
			for (int i = 2; i <= limit; i++)
			{
				if (number % i == 0) return false;
			}
			return true;
		}
	}
}
