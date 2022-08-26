using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Encapsulation
{
    class StaticDemo
    {
        static int x=0;
        StaticDemo()
        {
            x++;
            Console.WriteLine(x);
        }
        void Display()
        {
            Console.WriteLine(x);
        }
        static int Addition()
        {
            return 2+5;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(x);
            StaticDemo s = new StaticDemo();
            /*StaticDemo s1 = new StaticDemo();
            StaticDemo s2 = new StaticDemo();*/

            //  Console.WriteLine(s.x);   //error

            Console.WriteLine(StaticDemo.x);

            int ans = StaticDemo.Addition();
            Console.WriteLine("Addition="+ans);

        }
    }
}
