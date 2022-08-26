using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class StudAccessmodifier
    {
        static void Main(string[] args)
        {
            StudentAccessmodifier s1 = new StudentAccessmodifier();
           
            Console.WriteLine("Student Information");
            s1.Stud_detail();
            s1.Stud_nm();
           // s1.Stud_mark();
            //s1.Stud_addr();
        }
    }
}
