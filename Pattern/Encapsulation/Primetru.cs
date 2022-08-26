using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Encapsulation
{
    class Primetru
    {
        void Findprime(int n)
        {
            int i,prime = 0;

            Console.WriteLine("Enter any number");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    prime++;
                }
            }
            if (prime == 2)
            {
                Console.WriteLine("Entered number is prime");
            }
            else
            {
                Console.WriteLine("Entered number is Not prime");
            }
        }



        static void Main(string[] args)
        {
            Primetru p = new Primetru();
           // p.Findprime( );

        }
    }
}

