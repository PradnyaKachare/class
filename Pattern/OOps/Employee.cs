using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class Employee
    {
        public int id;
        public string name;
<<<<<<< HEAD
        public double salary;
        public string addr;

        public void AcceptDetails(int eid, string nm, double sal,string add)
        {
            id = eid;
            name = nm;
            salary = sal;
            addr = add;
=======
        public int salary;

        public void AcceptDetails(int eid, string ename, int sal)
        {
            id = eid;
            name = ename;
            salary = sal;
>>>>>>> 0b5e1c57d7d859a0e38fc826885c0f53ff390293
        }

        public void Display()
        {
<<<<<<< HEAD
            Console.WriteLine(id+""+name+""+salary+""+addr);
=======
            Console.WriteLine(id+""+name+""+salary);
>>>>>>> 0b5e1c57d7d859a0e38fc826885c0f53ff390293
        }

        static void Main(string[] args)
        {
            Employee e = new Employee();
<<<<<<< HEAD

            /* Employee e1 = new Employee();
             e1.AcceptDetails(2, "veda", 70000);
             e1.Display();*/
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter the employee Id:");
                int eid = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the employee Name:");
                string nm = Console.ReadLine();

                Console.WriteLine("Enter the employee sal:");
                double sal = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the employee add:");
                string add = Console.ReadLine();

                e.AcceptDetails(eid, nm, sal, add);
                e.Display();

                //e.AcceptDetails(1, "Shree", 90000, "pune");
            }
        }

=======
            e.AcceptDetails(1, "Shree", 90000);
            e.Display();

            Employee e1 = new Employee();
            e1.AcceptDetails(2, "veda", 70000);
            e1.Display();
        }
>>>>>>> 0b5e1c57d7d859a0e38fc826885c0f53ff390293
    }
}
