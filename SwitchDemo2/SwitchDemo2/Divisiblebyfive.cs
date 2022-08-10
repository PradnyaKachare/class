using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchDemo2
{
    class Divisiblebyfive
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter your Numbers:");
            num = Convert.ToInt32(Console.ReadLine());


            if (num % 5 == 0)
            {

                Console.WriteLine("Given number divisible of 5 ");

            }
            else


            {
                Console.WriteLine(" Given number is Not divisible of 5");

            }
        }
    }
}
