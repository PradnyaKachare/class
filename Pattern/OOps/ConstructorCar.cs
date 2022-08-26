using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class ConstructorCar
    {
        string model_no;
        String car_name;


        public ConstructorCar() 
        {
            Console.WriteLine("Default Constructor");
        }

        public ConstructorCar(String car_name, string model_no) : this()
        {
            this.car_name = car_name;
            this.model_no = model_no;

        }
        public void show()
        {
            Console.WriteLine(car_name + " " + model_no);
        }
    }

    class Thisuse3
    {
        static void Main(string[] args)
        {
            ConstructorCar BMW = new ConstructorCar();
            ConstructorCar audi = new ConstructorCar("Audi", "Q7");
            audi.show();

        }


    }

}