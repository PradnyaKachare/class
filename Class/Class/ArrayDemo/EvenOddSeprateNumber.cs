using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.ArrayDemo
{
    class EvenOddSeprateNumber
    {
        public static void Array(int []a)
        {
            int[] odd = new int[a.Length];
            int[] even = new int[a.Length];
            int j=0, k=0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    even[j] = a[i];
                    j++;
                }
                else
                {
                    even[k] = a[i];
                    k++;
                }
            }
            Console.WriteLine("Even Array");
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("  "+even[i]);
            }
            Console.WriteLine("Odd Array");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("  " + odd[i]);
            }
            
        }
    }
}
