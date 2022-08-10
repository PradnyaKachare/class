using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.ArrayDemo
{
    class SearchElement
    {
        public static bool FindElement(int[]a,int n)
        {
            bool isPresent = false;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==n)
                {
                    isPresent = true;
                    break;
                }
            }
            return isPresent;
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("nter Element");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Enter the Element for Search:");
            int num = int.Parse(Console.ReadLine());

            bool isElementFound = SearchElement.FindElement(a, num);

            if(isElementFound==true)
            {
                Console.WriteLine("Element Present");
            }
            else
            {
                Console.WriteLine("Element is Not Present");
            }
        }
    }
}
