using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Containment
{
    class Engine
    {
        string type;

        public string Type
        {
            get { return Type; }
            set { type = value; }
        }
    }
    class Car
    {
        int model_no;
        string cnm;
        int price;
        Engine en;

        public int Model_no
        {
            get { return model_no; }
            set { model_no = value; }
        }

        public string Cnm
        {
            get { return cnm; }
            set { cnm = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
         public Engine En
        {
            get { return en; }
            set { en = value; }
        }
    }

    class CareInfo
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Model_no = 567;
            c.Cnm = "BMW";
            c.Price = 98000;
            c.En = new Engine();
            c.En.Type = "Petrol";

            Console.WriteLine(c.Model_no+""+c.Cnm+""+c.Price+""+c.En.Type);
        }

    }
}
