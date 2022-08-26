using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class StudentDtl
    {
         int id;
         string name;
         float per;

        public void Stud_Dtl(int Sid,string Sname,float Sper)
        {
            id = Sid;
            name = Sname;
            per = Sper;
        }
        public void Grade()
        {
            if (per > 65)
            {
                Console.WriteLine("A");
            }
            else if(per>60)
            {
                Console.WriteLine("B");
            }
            else if (per>50)
            {
                Console.WriteLine("C");
            }
            else if(per<=0)
            {
                Console.WriteLine("error");
            }
            
        }
        public void Display_Stud_data()
        {
            Console.WriteLine(id + "" + name + "" + per);
        }
        static void Main(string[] args)
        {
            StudentDtl s = new StudentDtl();
                     
            s.Stud_Dtl(101,"Shaurya",80.9f);
            s.Display_Stud_data();
            s.Grade();
        }
    
    }


}
