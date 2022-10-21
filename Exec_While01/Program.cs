using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_While01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Q1 用 While 迴圈 1 + 2 + 3 + N < 105  請問 N 是多少
			int max = 105;
			int num = 1;
			int sum = 0;
			while(sum < max)
			{
				sum += num;
				num++;				
			}
			Console.WriteLine($"Q1: N = {num - 1}");
			Console.WriteLine();


			// Q2 使用 While 迴圈, 在畫面顯示所有可以整除 300 的整數, 例如: 1, 2, 3, 4, 5, 6, ... , 300

			int number = 300;
			num = 1;
			while (num < number)
			{
				if(number % num == 0)
				{
					Console.WriteLine($"Q2: 能整除300的整數為 {num}");
				}
				num++;
			}

		}
	}
}
