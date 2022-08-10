using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchDemo2
{
    class Switchdemo3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your String:");
            string str = (Console.ReadLine());

            switch (str)
            {
                case "happy":
                    Console.WriteLine("Happy");
                    break;

                case "new":
                    Console.WriteLine("New");
                    break;

                case "year":
                    Console.WriteLine("Year");
                    break;


                default:
                    Console.WriteLine("Welcome");
                    break;
            }
        }
    }
}

