using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.ArrayDemo
{
    class SortArray
    {
        public static int[] MySort(int[] a)
        {
           
            for (int i = 0; i < a.Length / 2; i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[i]<a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                    
                }
                
            }
            return a;
        }
        static void Main(string[] args)
        {
            int[] arr = { 13,52,47,3,45,47};
            Console.WriteLine(string.Join(" ", arr));
            int[] sorted = SortArray.MySort(arr);
            Console.WriteLine("..................................");
            Console.WriteLine(string.Join(" ", sorted));
        }
    }
}
