using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Containment
{
    class Department
    {
        public int d_id;
        public string d_nm;

        public Department(int d_id, string d_nm)
        {
            this.d_id = d_id;
            this.d_nm = d_nm;
        }

        public void showdepartment()
        {
            Console.WriteLine(""+d_id+""+d_nm);
        }
    }   
       
    class Employ
    {
        public int id;
        public string name;
        public double salary;
        Department dept;

       Employ (int id, string name, double salary, Department dept)
        {
            this. id = id;
            this.name = name;
            this.salary = salary;
            this.dept = dept;
        }
        public void DisplayEmploy()
        {
            Console.WriteLine(id + "" + name + "" + salary);
        }
        static void Main(string[] args)
        {
            /*Department d = new Department(101,"Computer");
            Employ e = new Employ(1,"veda",980000,d);
            e.DisplayEmploy();*/

            Employ emp = new Employ(105,"Shaurya",97000,new Department(302,"Testing"));
            emp.DisplayEmploy();

        }
    }
}
