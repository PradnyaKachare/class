using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Encapsulation
{
    class StaticDemo3
    {
        static StaticDemo3()
        {
            Console.WriteLine("hiiiiiiii");
        }
        StaticDemo3()
        {
            Console.WriteLine("Default Constructor");
        }

        static void Main(string[] args)
        {
            StaticDemo3 s = new StaticDemo3();
            StaticDemo3 s1 = new StaticDemo3();
        }
    }
}
