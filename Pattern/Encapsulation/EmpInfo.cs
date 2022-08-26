using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class Emp
    {
        int id;
        string name;
        double salary;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
    class EmpInfo
{
        static void Main(string[] args)
        {
            Emp e = new Emp();
            e.Id = 101;
            e.Name = "Veda";
            e.Salary = 90000;
        }
    }
}
