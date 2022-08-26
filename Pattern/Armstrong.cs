using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            int r, n,temp,sum=0;
            Console.WriteLine("Enter any number");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("Number is Armstrong ");
            }
            else
            {
                Console.WriteLine("Number is not Armstrong");
            }
        }
    }
}
