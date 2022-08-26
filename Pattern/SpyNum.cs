using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class SpyNum
    {
        static void Main(string[] args)
        {
            int n, sum=0,mul=1,r; 
            Console.WriteLine("Enter the Number");
            n = int.Parse(Console.ReadLine());
                      
            while (n !=0)
            {
                r = n % 10;
                sum=sum+ r;
                mul =mul*r;
                n/=10;

            }
            if (sum == mul)
                Console.WriteLine("This is Spy number");
            else
                Console.WriteLine("This is Not Spy number");
        }
    }
}
