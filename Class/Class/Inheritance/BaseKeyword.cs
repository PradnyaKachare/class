using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Inheritance
{
    class Biird
    {
        public int leg = 2;

        public void Color()
        {
            Console.WriteLine("Birds are different color \t" + leg);
        }
    }

    class Peacock : Biird
    {
        public Peacock() : base()
        {
            int leg = 4;
            Console.WriteLine("Peacock is colorful\t"+leg + " \t" + base.leg);
           //base.Color();
        }
    }
    class Parrot : Biird
    {
        /*public void Color()
        {
            Console.WriteLine("Parrot is Green");
            base.Color();
        }*/
    }
   
    class BaseKeyword
    {
        static void Main(string[] args)
        {
            Peacock p = new Peacock();
            // p.Color();
            Parrot r = new Parrot();
            r.Color();
        }
    }
}
