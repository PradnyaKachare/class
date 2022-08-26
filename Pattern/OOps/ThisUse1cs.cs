using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class ThisUse1cs
    {
        int x=10;


       public void input (int x)
        {
            this.x = x;
        }

        public void show()
        {
            Console.WriteLine("X="+x);
        }

        static void Main(string[] args)
        {
            ThisUse1cs t = new ThisUse1cs();
            t.input(450);
            t.show();
        }
    }
}
