using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class Car
    {
       string model_no;
       double price;
        string name;

        static void Main(string[] args)
        {
            Car c = new Car();
            c.model_no = "G9";
            c.price = 100000;
            c.name = "BMW";
            Console.WriteLine("Car Model Id:" + c.model_no + " Car Name: "  + c.name + " Car Price: "+c.price);

            Car c2 = new Car();
            c2.model_no = "Q8";
            c2.price = 200000;
            c2.name = "Audi";
            Console.WriteLine("Car Model Id:" + c.model_no + " Car Name: " + c.name + " Car Price: " + c.price);

        }
    }
}
