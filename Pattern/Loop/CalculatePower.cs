using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Loop
{
    class CalculatePower
    {
        static void Main(String[] args)
        {
            // Console.WriteLine(Math.Pow(4,3));

            Console.WriteLine("Enter the Base");
            int base_no = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Exponent");
            int Expo_no = int.Parse(Console.ReadLine());

            int power = 1;

            for (int i = 1; i <= Expo_no; i++)
            {
                power = power * base_no;
            }
            Console.WriteLine(power);
        }
    }
}
