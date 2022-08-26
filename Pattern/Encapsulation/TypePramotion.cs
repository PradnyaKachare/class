using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Encapsulation
{
    class TypePramotion
    {
        void Addition(int x,float f)     //formal parameter
        {
            Console.WriteLine(x+f);
        }
        static void Main(string[] args)
        {
            TypePramotion t = new TypePramotion();
            t.Addition(7, 5);

           // t.Addition(4,6.7);  //Actual parameter
        }
    }
}
