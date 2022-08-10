using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchDemo2
{
    class ChkAlphaDigitcs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any char");
            char ch = Convert.ToChar(Console.ReadLine());


            if (ch >='A' && ch<='Z')
            {

                Console.WriteLine("ALPHABET");
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("ALPHABET");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("Digit"); ;
            }
            else 
            {
                Console.WriteLine("Special Symbol");
            }
            
        }
    }
}
