using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Inheritance
{
    class Vehicle
    {
        protected int wheels = 4;
    }
       class Car : Vehicle
    {
    internal string cnm = "BMW";

    public void ShowCar()
     {
        Console.WriteLine(cnm + " " + wheels);
     }
     }

       class Truck : Vehicle
    {

    public void ShowTruck()
    {
                wheels = 8;
        Console.WriteLine("Truck Wheels" + wheels);
    }
    }
         class HirachicalDemo
        {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.ShowCar();
            Truck t = new Truck();
            t.ShowTruck();

        }
    }
}
