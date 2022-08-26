using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Encapsulation
{
    class CarProperty
    {
        int mod_no;
        string nm;
        string clr;
        int price;

        public int Mod_no
        {
            get 
            {
                return mod_no; 
            }
            set 
            { 
                mod_no = value;
            }
        }

        public string Nm
        {
            get 
            { 
                return nm;
            }
            set 
            {
                nm = value;
            }
        }
        public string Clr
        {
            get 
            {
                return clr;
            }
            set
            { 
                clr = value;
            }

        }
        public int Price
        {
            get
            { 
                return price;
            }
            set
            {
                price = value;
            }
        }
    }

        class CarInfo
        {
             static void Main(string[] args)
             {
                  CarProperty c = new CarProperty();
                    /*c.mod_no = 104;
                    c.nm = "Audi";
                    c.clr = "Red";
                    c.price = 650000;*/
                 //Console.WriteLine("Model number="+c.mod_no + "Name="+c.nm+ "Color=" +c.clr+"Price= "+c.price);
             }

        }
           
}
