using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Loop
{
    class LoopDemo
    {
        //loop Demo


        static void Main(string[] args)
        {
            //print 5 tym hello world
            /* int i;
             for(i=1;i<=5;i++)
             {
                 Console.WriteLine("hello world");
             }
             */

            //print 1 to 5


            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }



            //print 5 to 1

            /* int i = 5;
             for(;i<=5;i--)
                 Console.WriteLine(i);     //o/p- infinite loop*/



            /*for (int i = 1; ; i--)
            {
                Console.WriteLine(i);        //o/p- infinite loop
            }*/



            /*for(; ; )
            {
                Console.WriteLine("hi");               //o/p- infinite loop
            }*/



            /* for (int i=1;i<=5;i++) ;
             {
                 Console.WriteLine("hii");                  //1 time print hi
             }*/

        }

    }
}
