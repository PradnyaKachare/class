using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class IMEINO
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 15 digit number:");
            long n = long.Parse(Console.ReadLine());
            long sum = 0;

            while (n > 0)
            {
                long r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
            if (sum % 10 == 0)
            {
                Console.WriteLine("IMEI Number");

            }
            else
            {
                Console.WriteLine("Not IMEI number");
            }
        }
    }
}
