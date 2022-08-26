using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class ThisKeywordAllInOne
    {
<<<<<<< HEAD
        int id;
        string name;
        int tot;

        ThisKeywordAllInOne(int id,string name) : this()
        {
            this.id = id;
            this. name = name;
            this.Disply();

        }
        ThisKeywordAllInOne()
        {
            int m1=73, m2=86;
            tot = m1 + m2;
          
        }
        void Disply()
        {
            Console.WriteLine(id+""+name+""+tot);
        }
        static void Main(string[] args)
        {
            ThisKeywordAllInOne t = new ThisKeywordAllInOne(101,"Veda");          

        }
=======

>>>>>>> 0b5e1c57d7d859a0e38fc826885c0f53ff390293
    }
}
