using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Encapsulation
{
    class StaticDemo2
    {
        int x = 10;
        static int y = 56;

        void Show()
        {
            Console.WriteLine(x+"   "+y);
        }

        static void MyMethod()
        {
            StaticDemo2 s = new StaticDemo2();
            Console.WriteLine(s.x+""+y);
            //s.Show;
            int z = s.x + y;
        }
        static void Main(string[] args)
        {
            StaticDemo2 d = new StaticDemo2();
            d.Show();
            StaticDemo2.MyMethod();
           // Console.WriteLine(x);
        }
    }
}
