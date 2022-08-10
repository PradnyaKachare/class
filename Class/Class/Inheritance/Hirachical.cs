using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Inheritance
{
    class Animal
    {
       protected string color = "Black";
    }

    class Cat :Animal
    {
        internal int leg=4;

        public void ShowCat()
        {
            Console.WriteLine(leg + " "+ color);
        }
    }

    class Rabbit :Animal
    {
      
        public void ShowRabbit()
        {
            color = "white";
            Console.WriteLine("Rabbit Color" + color);
        }
    }
    class Hirachical
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.ShowCat();
            Rabbit r = new Rabbit();
            r.ShowRabbit();
        }
    }
}
