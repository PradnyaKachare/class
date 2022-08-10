using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchDemo2
{
    class TeenAge
    {
        static void Main(string[] args)
        {

            int a;
            Console.WriteLine("Enter your age:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a <= 18)
            {
                Console.WriteLine("yor are teenager");
            }
            else
            {
                Console.WriteLine("Your are not teenager");
            }


        }
    }
}
