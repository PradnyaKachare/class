using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class fact
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());

            int f = 1;

            for (int i = 1; i <= num; i++)
            {
                f = f * i;
            }

            Console.WriteLine(f);

        }
    }
}
