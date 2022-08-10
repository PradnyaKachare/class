using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchDemo2
{
    class CompareThreeno
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter your First Numbers:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Second Numbers:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your third Numbers:");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("A is greater than b & c");
                }
            }
            else if (b > c)
            {
                if (b > c)
                {
                    Console.WriteLine("b is greater than a & c");
                }
            }
            else
            {
                Console.WriteLine("c is greater than a & b");

            }
        }
    }
}
