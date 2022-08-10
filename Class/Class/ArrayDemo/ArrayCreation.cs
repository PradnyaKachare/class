using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.ArrayDemo
{
    class ArrayCreation  //on screen keyboard
    {
        static void Main(string[] args)
        {
           // int x = 10;
        
        //1.way

        int[] arr = { 5, 34, 78, 1 };
            // Array[4]=88;

            //2.way

            int[] myarray = new int[5];

        //3.Way using new Keyword

        int[] a = new int[5];

            /*  a[0]=25;
              a[1]=15;
              a[2]=42;
              a[3]=63;
              a[4]=78;*/

            Console.WriteLine("Enter the array Element");

            for(int i=0;i<a.Length;i++)
            {
                a[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("......Display Array....... ");
            //1.way
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine( a[i] +" ");
            }

            //2.way
            Console.WriteLine(" ");
            Console.WriteLine("............. ");
            foreach(int x in a)
            {
                Console.WriteLine(x);
            }

            //3.Way

            Console.WriteLine(string.Join("",a));
        }

    }
}
