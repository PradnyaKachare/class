using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Disaeiumnumber
    {
        static void Main(string[] args)
        {     
         
            Console.WriteLine("Enter any number");
            int n = int.Parse(Console.ReadLine());

           int temp = n;
           int count = 0;

            while (n > 0)
            {
                count++;
                n = n / 10;
            }
            Console.WriteLine("length of number :\t" +count);
            n = temp;
            int sum = 0;
            while(n>0)
            {
                int r = n%10;
                int power = 1;
                for(int i=1;i<=count;i++)
                {
                    power = power * r;
                }
                sum = sum + power;
                count--;
                n = n / 10;

            }
            Console.WriteLine("sum :\t"+sum);
            n = temp;
            if(n==sum)
            {
                Console.WriteLine("\n Number is Disarium");
            }
            else
            {
                Console.WriteLine("Number is Not Disarium");
            }
        }
    }
}
