using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Vehicle
    {
        public string typ_veh;
        public int mod_no, wheels, avg;

        public void Acceptdtl(int no,int whl,string typ)
        {
            mod_no = no;
            wheels = whl;
            typ_veh = typ;
        }
        public void averag()
        {
            if (wheels >= 2 && wheels <= 4)
            {
                avg = 20;
            }
            else if (wheels >= 8)
            {
                avg = 30;
            }
        }
             public void Display()
            {
            Console.WriteLine();
            }

        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.averag();
            v.Acceptdtl(4,8,"Truck");
            v.Display();
        }

       
    }

}