using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.ArrayDemo
{
    class SumOfEven
    {
        public int EvenSum(int []a)
        {
            int sum = 0;
            int i;
            for ( i = 0; i < a.Length; i++)
            {
                if(a[i]%2==0)
                {
                   
                    sum = sum + a[i];
                }
                Console.WriteLine("  " + a[i]);
            }
           
            return sum;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the array Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                
                arr[i] = int.Parse(Console.ReadLine());
            }
            SumOfEven e = new SumOfEven();
            int sum = e.EvenSum(arr);
            Console.WriteLine("....................");
            Console.WriteLine("sum of even number="+sum);
        }
    }
}
