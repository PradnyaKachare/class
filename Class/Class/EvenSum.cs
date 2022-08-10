using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class EvenSum
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.WriteLine("Enter any number:");
             n = int.Parse(Console.ReadLine());
            for(i=2;i<=n;i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
            int ave = sum / 2;
        }
    }
}
