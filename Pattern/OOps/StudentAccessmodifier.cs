using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class StudentAccessmodifier
    {
        public int rn = 111;
        internal string name = "Veda";
        private string addr = "Akluj";
        protected int mark = 92;

        public void Stud_detail()
        {

            Console.WriteLine(" student Roll no:" + rn);
        }

        internal void Stud_nm()
        {
            Console.WriteLine(" student name:" + name);
        }

        protected void Stud_mark()
        {
            Console.WriteLine("Student mark=" + mark);
        }

        private void Stud_addr()
        {
            Console.WriteLine(" student Address:" + addr);
        }


        static void Main(string[] args)
        {
            StudentAccessmodifier s = new StudentAccessmodifier();
            s.Stud_detail();
            s.Stud_nm();
            s.Stud_mark();
            s.Stud_addr();
        }
    }
}
