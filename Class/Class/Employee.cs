using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Employee
    {
        public int id;
        public string name;
        public double salary;
        public string address;

           
        public void AcceptDetails(int eid,string ename,double esal,string adr)
        {
            id = eid;
            name = ename;
            salary = esal;
            address = adr;
        }

        public void Display()
        {
            Console.WriteLine(id+""+name+""+salary+""+address);
           
        }

        static void Main(string[] args)
        {
            for (int i = 1; i <= 2; i++)
            {


                Employee e = new Employee();

                Console.WriteLine("Enter Employee Id:");
                int eid = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Employee Name:");
                string ename = Console.ReadLine();

                Console.WriteLine("Enter Employee Salary:");
                double esal = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Employee Address:");
                string adr = Console.ReadLine();
                e.AcceptDetails(eid, ename, esal, adr);

                e.Display();
                // e.AcceptDetails(1, "Pradnya", 7832.568, "Pune");
            }
            
        }
    }
}
