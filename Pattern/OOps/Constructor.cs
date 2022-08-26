using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class Constructor
    {
<<<<<<< HEAD
        int x=10;

        public Constructor()
=======
        int x;
        public Constructor()                                 
>>>>>>> 0b5e1c57d7d859a0e38fc826885c0f53ff390293
        {
            Console.WriteLine("Default Constructor");
        }

        public Constructor(string str)
        {
            Console.WriteLine("Parameter=" + str);
        }

        static void Main(string[] args)
        {
            Constructor c = new Constructor();
            Console.WriteLine(c.x);

            Constructor c2 = new Constructor("Pune");
        }
    }
}
