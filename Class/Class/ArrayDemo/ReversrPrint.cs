using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.ArrayDemo
{
    class ReversrPrint
    {
        static void Main(string[] args)
        {
            int[] a = { 11,44,22,55};
            Console.WriteLine(string.Join("",a));
            for (int i = a.Length-1; i<=0; i--)
            {
                Console.WriteLine( a[i] +" ");
            }
        }
    }
}
