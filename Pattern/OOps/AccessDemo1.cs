using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class AccessDemo1
    {
        private int x = 10;
        internal int y = 30;
        protected string name = "pune";
        public int z = 80;

        static void Main(string[] args)
        {
            AccessDemo1 d = new AccessDemo1();
            Console.WriteLine(d.x);
            Console.WriteLine(d.y);
            Console.WriteLine(d.name);
            Console.WriteLine(d.z);
        }
    }
}
