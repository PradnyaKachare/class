using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.ArrayDemo
{
    class OddCount
    {
        public static int OddElement(int []a)
        {
            int count = 0;
           
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int count=0;
            Console.WriteLine("Enter the array Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            OddCount o = new OddCount();
            //int count= o.OddElement(arr);
            Console.WriteLine("Odd Count=" + count);
        }
    }
}
