using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Inheritance
{
    class Frut
    {
        internal string Test = "Sweet";
    }

    class Mango : Frut
    {
        public  void show()
        {
            Console.WriteLine(Test);
        }

    }
    class Single
    {
        static void Main(string[] args)
        {
            Mango m = new Mango();
        }
    }
}
