using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Series
{

                                 //  .Accept number from user find out if number is prime continue till user enters negative number
    class Prime
    {
       static void Main(string[] args)
        {
            /*int n, i, pr = 0;
            Console.WriteLine("Enter the range of number(Limit):");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                pr = (pr * 2) + 1;

                Console.WriteLine(pr);
            }*/

            int n;
            bool prime = true;
            /*while (n != 0)
            {*/
                
                Console.Write("enter a number: ");
                  n = int.Parse(Console.ReadLine());
            /*Console.WriteLine("Enter the range of number(Limit):");
            n = int.Parse(Console.ReadLine());*/

            for (int i = 1; i <= n; i++)

                //if (n < 0)
                {
                    Console.WriteLine("Number is negative");
                 
                /*}
                else
                {*/
                    //variable for subprogram
                   // bool prime = IsPrimeNumber(n);

                    //output
                    if (prime == true)
                    {

                        Console.WriteLine("Number is Prime");
                  
                    }

                    else if (prime == false)
                    {
                        Console.WriteLine("Number is not Prime");
                    }
                }
            //}

            Console.WriteLine("End of program");
            Console.ReadKey();
        }
    }
}
