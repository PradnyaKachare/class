using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Series
{
	class series1                       //    1,3,7,15,31,63,127 generate first n numbers of above series.
	{                                      //    Input: n=5 Output: 1 3 7 15 31 /* 0*2+1  1*2+1  3*2+1  7*2+1  15*2+1*/
		static void Main(string[] args)
		{
			int n, i, pr = 0;
			Console.WriteLine("Enter the range of number(Limit):");
			 n = int.Parse(Console.ReadLine());

			for (i = 1; i <= n; i++)
			{
				pr = (pr * 2) + 1;

				Console.WriteLine(pr);
			}
				
			/*int n, i, pr = 0;
			("Enter the range of number(Limit):");
			n = sc.nextInt();
			for (i = 1; i <= n; i++)
			{
				pr = (pr * 2) + 1;
				System.out.print(pr + " ");
			}
			sc.close();*/
		}
	}
}
