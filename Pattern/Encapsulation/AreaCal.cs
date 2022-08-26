using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Encapsulation
{
    class AreaCal
    {
       void Area(float r )
        {
            double circle = 3.14 *r*r ;
            Console.WriteLine("Area of Circle =" + circle);
        }
        void Area(int l,int w)
        {
            
            int Rectangle =l*w ;
            Console.WriteLine("Area of Rectanle=" + Rectangle);
        }
        void Area(int b,float h)
        {

            double Triangle =1/2 * b * h;
            Console.WriteLine("Area of Triangle=" + Triangle);
        }
        void Area(int a)
        {

            int Square = a*a;
            Console.WriteLine("Area of squre=" + Square);

        }
        static void Main(string[] args)
        {
            AreaCal a = new AreaCal();
            a.Area(8);
            a.Area(12,6);
            a.Area(53,2);
            a.Area(6);


        }
    }
}
