﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.ArrayDemo
{
    class ReverseCharArray
    {
        public void RevArray(char[] ch)
        {
            for (int i = ch.Length - 1;i>=0; i++)
            {
                Console.WriteLine(ch[i]+"");  
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array Size");
            int s = int.Parse(Console.ReadLine());

            char[] ch = new char[s];
         
            Console.WriteLine("Enter the char Elements");

            for (int i = 0; i <= ch.Length - 1; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("............. ");
            foreach (char c in ch)
            {
                Console.Write(c);
            }
            
            

        }
    }
}
