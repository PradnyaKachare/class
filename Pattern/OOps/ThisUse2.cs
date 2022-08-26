using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class ThisUse2
    {
        public void input()
        {
            Console.WriteLine("Input Method");
            this.show();
        }

        public void show()
        {
            Console.WriteLine("Show Method");
        }

        static void Main(string[] args)
        {
            ThisUse2 t = new ThisUse2();
            t.input();
           
        }
    }
}
