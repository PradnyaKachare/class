using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Inheritance
{
    //sealed class Flower
        class Flower
    {
        public virtual void color()
        {
            Console.WriteLine("Colorful Flowers");
        }
    }

    class Rose : Flower  //cant inherit sealed class
    {
        public sealed override void color()
        {
            Console.WriteLine("Rose Colorful Flowers");

        }
    }
        class SealedDemo
        {
            static void Main(string[] args)
            {

            }
        }
    }
