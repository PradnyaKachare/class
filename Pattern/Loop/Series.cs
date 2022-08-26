using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Loop
{
    class Series
    {

        static void Main(string[] args)
        {
            //2 5 10 17 26


            /*for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i*i+1 +" ");
            }*/



            //1 4 3 16 5 36 


            /*for (int i = 1; i <= 10; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i * i +" ");
                }else
                {
                    Console.WriteLine(i  + " ");
                }
            }*/



            //-1 4 -3 16 -5 36 


            /*   for (int i = 1; i <= 10; i++)
               {
                   if (i % 2 == 0)
                   {
                       Console.WriteLine(i * i + " ");
                   }
                   else
                   {
                       Console.WriteLine(-i + " ");
                   }
               }*/


            //1 8 9 64 25

            /* for (int i = 1; i <= 10; i++)
             {
                 if (i % 2 == 0)
                 {
                     Console.WriteLine(i * i * i + " ");
                 }
                 else
                 {
                     Console.WriteLine(i * i + " ");
                 }
             }*/



            int count = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    count = count + 1;
                }

            }
            Console.WriteLine(count);

        }
    }
}
