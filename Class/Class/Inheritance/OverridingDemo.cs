using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Inheritance
{
    class Fruit
    {
        public virtual void Test()

        {
            Console.WriteLine("Test is Sweet");            
        }
    }
    class Mangoo:Fruit
    {
        public override void Test()
        {
            Console.WriteLine("Mango is Sweet");
            base.Test();
        }
    }
    class Banana : Fruit
    {
        public override void Test()
        {
            Console.WriteLine("Banana is Sweet");
            
        }
    }
    class OverridingDemo
    {
        static void Main(string[] args)
        {
           /* Mangoo m = new Mangoo();
            m.Test("Bitter");
*/
            Fruit f = new Mangoo();
            f.Test();

            Fruit f1 = new Banana();
            f1.Test();
        }
    }
}
