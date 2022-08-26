using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Loop
{
    class EvenAddition
    {
        static void Main(string[] args)
        {
            //addition of even no.bet 1 to20

            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {

                    sum = sum + i;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
