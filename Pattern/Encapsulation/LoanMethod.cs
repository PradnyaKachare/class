using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Encapsulation
{
    class LoanMethod
    {
       
        float lon;

        float Loan(int p,float r,int t)
        {

            return lon = (float) p * r * t;
        }
        float Loan(int p, float r1,float r2,int t)
        {
            float lon1;
            if(t<=6)
            {
                return lon1 = (float)p * r1 * t;
            }
            else 
            {
                return lon1 = (float)p * r2 * t;
            }
        }
        static void Main(string[] args)
        {
            LoanMethod l = new LoanMethod();
            Console.WriteLine(l.Loan(2500,4f,5));
            Console.WriteLine(l.Loan(50000,6f,5f,6));
        }
    }
}
