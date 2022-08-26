using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Encapsulation
{
    class StaticOverriding
    {
        static int x = 23;
        static int y = 15;


        static void Calculate()
        {
            int add = x + y;
            Console.WriteLine("Addition=" + add);
        }

       /* static void Calculate()
        {
            int sub = x - y;
            Console.WriteLine("substraction+" + sub);

        }
*/
        static void Main(string[] args)
        {
            StaticOverriding s = new StaticOverriding();
                // s.Calculate();
           
        }
    }
}
