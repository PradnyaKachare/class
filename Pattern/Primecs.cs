using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1
{
    class Primecs
    {
        static void Main(string[] args)
        {
            int i, n, prime = 0;
          
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
    }
}
