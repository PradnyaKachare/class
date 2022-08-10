using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchDemo2
{
    class ChkVowl
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Char:");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Vowel");
            }

            else
            {
                Console.WriteLine("Cosonent");
            }



            //second method

            /* if (ch == 'a')
             {
                 Console.WriteLine("Vowel");
             }
             else if(ch == 'e')
             {
                 Console.WriteLine("Vowel");
             }
             else if (ch == 'i')
             {
                 Console.WriteLine("Vowel");
             }
             else if (ch == 'o')
             {
                 Console.WriteLine("Vowel");
             }
             else if (ch == 'u')
             {
                 Console.WriteLine("Vowel");
             }
             else 
             {
                 Console.WriteLine("Cosonent");
             }*/
        }
    }
}
