using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Inheritance
{
    class Animaal
    {
        public int legs = 4;
    }
    class Frog:Animaal
    {    
        public void show()
        {
            legs = 2;
            Console.WriteLine("Frog Legs="+legs+""+"Animal legs"+base.legs);          //Bsae to acces variable into child
        }

    }
    class Dog:Animaal
    {
        public void Display()
        {
            Console.WriteLine("Dog legs="+base.legs);
        }      

    }
    class Base1
    {
        static void Main(string[] args)
        {
            Frog f = new Frog();
            f.show();
            Dog d = new Dog();
            d.Display();
        }
    }
}
