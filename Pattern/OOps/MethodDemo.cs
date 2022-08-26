using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class MethodDemo
    {
        //no return type no parameter
        public void Show()
        {
            Console.WriteLine("show method");
        }

        //No return type with Parameter
        public void Addition(int x, float y)
        {
            float result = x + y;
            Console.WriteLine("result=" + result);
        }

        //No return type with Parameter

        public int AreaRectangle()
        {
            int a = 5 * 4;
            return a;
        }

        //with return type with parameter

        public float AreaOfCirclr(int r)
        {
            float PI = 3.14f;
            return (PI * r * r);
        }

       
    }
    class Demo
    {
        static void Main(string[] args)
        {
            MethodDemo d = new MethodDemo();


            d.Show();                               //no return type no parameter


            d.Addition(5, 8.9f);                    //No return type with Parameter


            int myArea = d.AreaRectangle();           //No return type with Parameter
            Console.WriteLine("Area of Rectangle="+ myArea);

            float cirArea = d.AreaOfCirclr(7);           //with return type with parameter
            Console.WriteLine("Area Of Circle="+ cirArea);


        }
    }
}
