using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchDemo2
{
    class largenum1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());

            if(num1>num2)
            {
                Console.WriteLine("Num1 is greater" +num1);
            }
            else 
            {
                Console.WriteLine("Num2 is greater" + num2);
            }
        }
    }
}