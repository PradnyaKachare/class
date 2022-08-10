using System;

namespace singledigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
               
            Console.WriteLine("Enter your  Numbers:");
            a = Console.ReadLine();
           

            if (a.Length < 2)
            {

                Console.WriteLine("Entered number is single digit ");

            }
            else


            {
                Console.WriteLine(" Entered number is Double digit");

            }
        }
    }
}
