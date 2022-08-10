using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.ArrayDemo
{
    class CharArrayDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array Size");
            int size=int.Parse(Console.ReadLine());

            char[] ch  = new char[size];
            Console.WriteLine("Enter the char Elements");

            for (int i = 0; i <= ch.Length-1; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }

            // char[] ch  ={'u','p','d','A','#'};

            Console.WriteLine("............. ");
            foreach (char c in ch)
            {
                Console.WriteLine(c);
            }
        }
    }
}
