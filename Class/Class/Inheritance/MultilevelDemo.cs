using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Inheritance
{
    class person
    {
        internal string P_nm = "Pradnya";

        public void ShowPerson()
        {
            Console.WriteLine("Name:"+P_nm);
        }
    }
     
    class Employee : person 
    {
       internal int sal=780000;
        
        public void ShowEmp()
        {
            Console.WriteLine(P_nm+"" +sal);
        }
    }
    class Manager:Employee
    {
        int commition = 3000;

        public void ShowManager()
        {
            Console.WriteLine(P_nm + "" + sal+""+commition);
        }

    }

    class MultilevelDemo
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.ShowPerson();
            m.ShowEmp();
            m.ShowManager();
        }
       
    }
}
