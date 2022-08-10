using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Inheritance
{
    class Mobile
    {
        internal string memory_size = "64Gb";
    }

    class Apple:Mobile
    {
        public 
            void show()
        {
            Console.WriteLine(memory_size);
        }

    }
    class singleDemo
    {
        static void Main(string[] args)
        {
            Apple a = new Apple();
            a.show();
            Console.WriteLine(a.memory_size);
        }
    }
}
