 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class AccessModifier :AccessDemo1         //child class inheritance
    {
        static void Main(string[] args)
        {
            AccessDemo1 a = new AccessDemo1();
          //  Console.WriteLine(a.x);
            Console.WriteLine(a.y);
            Console.WriteLine(a.z);

            AccessModifier m = new AccessModifier(); 

            Console.WriteLine(m.name);
            Console.WriteLine(m.y);
            Console.WriteLine(m.z);

        }
    }
}
