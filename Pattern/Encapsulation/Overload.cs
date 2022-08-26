using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Encapsulation
{
    class Overload
    {
        int j=25, g=5;
        void Calculate(float a,float b)
        {
          float  add = a + b;
            Console.WriteLine("Addition ="+add);
        }
        void Calculate(int x)
        {
            int y = 5;
            int sub = x - y;
            Console.WriteLine("Substraction="+sub);
        }
        void Calculate(int p,int q)
        {
            
            int mul = p * q;
            Console.WriteLine("Multiplication="+mul);
        }
        void Calculate()
        {
            
            int div = j / g;
            Console.WriteLine("Division="+div);

        }
        static void Main(string[] args)
        {
            Overload o = new Overload();
            o.Calculate(18.2f, 54.4f);
            o.Calculate(68);
            o.Calculate(45,6);
            o.Calculate();


        }
    }
}
