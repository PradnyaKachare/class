using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.ArrayDemo
{
    class EvenNumberPosition
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the array Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            SumOfEven e = new SumOfEven();
            int sum = e.EvenSum(arr);
            Console.WriteLine("sum of even number=" + sum);
        }
    }
}
