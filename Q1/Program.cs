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
			/*Q1
			1 + 2 + 3 + 4 + ....+N < 105
			請問 N 是多少 ?*/
			int i = 0;
			int sum = 0;
			while (sum < 105)
			{
				sum += i;
				i++;
			}
			Console.WriteLine(i);
		}
	}
}
