using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Inheritance
{
    class Bird
    { 
     public void Fly()
        {
            Console.WriteLine("Bird is Flying");
        }
    }

    class Sparrow:Bird
    {
        /*public void Fly()
        {
            Console.WriteLine("Sparrow is Flying");                                     //access to method
            base.Fly();
        }
*/
    }
    class Base2
    {
        static void Main(string[] args)
        {
            Sparrow s = new Sparrow();
            s.Fly();
        }
    }
}
