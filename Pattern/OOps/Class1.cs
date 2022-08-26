using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
<<<<<<< HEAD
{                                 //Student_Percentage
=======
{
>>>>>>> 0b5e1c57d7d859a0e38fc826885c0f53ff390293
    class StudPer
    {
        public int id;
        public string name;
        public double per;

        public void acceptDetails(int id1,string name1)
        {
            id = id1;
            name = name1;
        }
        public void getPer(double m1,double m2,double m3)
        {
           per = ((m1 + m2 + m3) / 300) * 100;
        }
        public string getDetails()
        {
            return "Id: "+id + " Name: " +name+ " Per: " +per;
        }


        static void Main(string[] args)
        {
            StudPer s = new StudPer();
            s.acceptDetails(1, "Pradnya");
<<<<<<< HEAD
            s.getPer(45, 60, 70);
=======
          s.getPer(45, 60, 70);
>>>>>>> 0b5e1c57d7d859a0e38fc826885c0f53ff390293
            string studDtails = s.getDetails();
            Console.WriteLine(studDtails);

        }
    }
}
