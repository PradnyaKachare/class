using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchDemo2
{
    class Age
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter your age:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Friend age:");
            b = Convert.ToInt32(Console.ReadLine());

            if (a >= b)
            {
                Console.WriteLine("Hi friend");
            }
            else
            {
                Console.WriteLine("How are you");
            }

        }
    }
}
