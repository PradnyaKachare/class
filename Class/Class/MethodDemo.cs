 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class MethodDemo
    {
        int y;
        public void Show()
        {
            Console.WriteLine("Show method");
        }

        public void Calculate(int x,string str)
        {
            Console.WriteLine(str);
             y = x * x * x ;
        }

        public void Display()
        {
            Console.WriteLine(y);
        }

        public double AreaOfCircle()
        {
            double PI = 3.14;
            double area = PI * 3 * 3;
            return area;
        }
        public int Addition(int a,int b)
        {
            return (a + b);
        }
        static void Main(string[] args)
        {
            MethodDemo m = new MethodDemo();
            m.Show();

            m.Calculate(3,"Pune");
            m.Display();

            double a = m.AreaOfCircle();
            Console.WriteLine("Area Of Circle:"+a);

           // Console.WriteLine(m.AreaOfCircle());

            int result = m.Addition(6, 7);
            Console.WriteLine("Addition:"+result);

           // Console.WriteLine("Addition:"+m.Addition(8,8));
        }
    }
}
