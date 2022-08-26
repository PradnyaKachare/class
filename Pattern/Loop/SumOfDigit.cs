using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Loop
{
    class SumOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            while (num > 0)
            {
                int r = num % 10;
                sum = sum + r;
                num = num / 10;

            }
            Console.WriteLine("Sum of number" + sum);
        }
    }
}
