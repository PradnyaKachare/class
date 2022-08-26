using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Loop
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());

            bool isprime = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isprime = false;

                }

            }

            if (isprime == true)
            {

                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }

        }
    }
}
