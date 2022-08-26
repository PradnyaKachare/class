using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Atomorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int n = int.Parse(Console.ReadLine());
            int rem = n % 10;
            int sq = n * n;
            int sqRem = sq % 10;
            if(rem == sqRem)
            {
                Console.WriteLine("Entered number Automorphic");
            }
            else
            {
                Console.WriteLine("Entered number not Automorphic");
            }
        }
        }
}
