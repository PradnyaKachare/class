using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Operator
    {
        static void Main(string[] args)
        {

            int x = 15;
            int result;

            Console.WriteLine("x is " + x);        //15
            result = x++;                          //15+1
            Console.WriteLine("Post increment of x is " + x);   //16

            Console.WriteLine("x is " + x); //16
            result = x--;                        //16-1
            Console.WriteLine("Post decrement of x is " + x);    //15

            Console.WriteLine("x is " + x);                            //15
            result = ++x;                                                //15+1
            Console.WriteLine("Pre increment of x is " + x);         //16

            Console.WriteLine("x is " + x);                           //16
            result = --x;                                               //16-1
            Console.WriteLine("Pre decrement of x is " + x);             //15
        }
    }
}
