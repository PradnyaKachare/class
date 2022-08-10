using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchDemo2
{
    class Nesteddemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Weight");
            int wt = int.Parse(Console.ReadLine());

            /* if (age >= 18 && wt>=50)
             {
                 Console.WriteLine("Valid for blood Donation");
             }
             else
             {
                 Console.WriteLine("Not Valid");
             }*/


            //second method

            if (age > 18)
            {
                if (wt > 50)
                {
                    Console.WriteLine("Valid for blood Donation");
                }
                else
                {
                    Console.WriteLine("person age valid  but not weight try next time........ ");
                }
            }
            else
            {
                Console.WriteLine("person a not valid for blood donation try next time........ ");
            }

        }
    }
}
