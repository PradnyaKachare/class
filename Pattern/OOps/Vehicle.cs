using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class Vehicle
    {
        public int typeofvehicle;
        public int modelnm;
        public int wheels;
        public int average;

        public void AcceptDetails(int typev, int modnm, int wheel)
        {
            typeofvehicle = typev;
            modelnm = modnm;
            wheels = wheel;

        }
        public void Average(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i > 2 && i < 5)
                {
                    average = 15;
                }
                else if (i > 5)
                {
                    average = 20;
                }
            }

        }

        public void Display()
        {
            Console.WriteLine(typeofvehicle + "" + modelnm + "" + wheels + "" + average);
        }

        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();


            for (int i = 1; i <= 3; i++)
            {
                /* Console.WriteLine("Enter the employee Id:");
                 int eid = int.Parse(Console.ReadLine());

                 Console.WriteLine("Enter the employee Name:");
                 string nm = Console.ReadLine();

                 Console.WriteLine("Enter the employee sal:");
                 double sal = double.Parse(Console.ReadLine());

                 Console.WriteLine("Enter the employee add:");
                 string add = Console.ReadLine();

                 v.AcceptDetails(typeofvehicle, modelnm, wheels, average);
                 v.Display();
 */
                //e.AcceptDetails(1, "Shree", 90000, "pune");
            }
        }
    }
}
