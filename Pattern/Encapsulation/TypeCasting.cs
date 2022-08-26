using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Encapsulation
{
    class TypeCasting
    {
        static void Main(string[] args)
        {
            /*int x=4;
            float t=x;
            Console.WriteLine(t);*/

            float f = 56.78f;
            int y = (int)f;
            Console.WriteLine(y);
        }
    }
}
