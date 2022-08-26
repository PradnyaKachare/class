using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Inheritance
{
    class Laptop
    {
        public Laptop(int x)
        {
            Console.WriteLine("Laptop"+x);
        }
    }

    class Dell:Laptop
    {
        public Dell(int x,int y):base(y)  //:base(64)      //non pramerter also write call base to constructor
        {
            Console.WriteLine("Dell..."+x);
        }
    }

   
    class Base3
    {
        static void Main(string[] args)
        {
            Dell d = new Dell(32,120);
        }
    }
}
