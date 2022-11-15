using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入一個數: ");
			string value = Console.ReadLine();

			bool isNumber = int.TryParse(value, out int number);
			if (!isNumber)
			{
				Console.WriteLine("輸入非數值!!!");
				return;
			}
			
			if (IsPrime(number))
				Console.WriteLine($"{number}是一個質數");
			else
				Console.WriteLine($"{number}不是一個質數");
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
