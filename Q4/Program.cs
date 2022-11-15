using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 100; i++)
				for (int j = 1; j <= 100; j++)
					for (int k = 1; k <= 100; k++)
						if ((i + j + 3 * k ) == 100 && (5 * i + 3 * j + k) == 100)
						{
							Console.WriteLine($"公雞有 {i} 隻");
							Console.WriteLine($"母雞有 {j} 隻");
							Console.WriteLine($"小雞有 {3 * k} 隻");

							Console.WriteLine();
						}
		}
	}
}
