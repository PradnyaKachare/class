using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Inheritance
{
    class School
    {
        internal string stud_nm = "Pradnya";

    public void ShowSchool()
    {
        Console.WriteLine("Name:" + stud_nm);
    }
    }

      class ClassRoom : School
    {

    internal int id = 101;

         public void ShowClassRoom()
         {
           Console.WriteLine(stud_nm + "" + id);
          }
     }

      class Liabrary : ClassRoom
    {
         string book = "Computer science";

         public void ShowLiabrary()
       {
        Console.WriteLine(stud_nm + "" + id + "" + book);
       }

}

       class Multilevel
        {
        static void Main(string[] args)
        {
            Liabrary l = new Liabrary();
            l.ShowSchool();
            l.ShowClassRoom();
            l.ShowLiabrary();
        }
       }
}
