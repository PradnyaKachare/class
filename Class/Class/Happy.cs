using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Happy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Number");
            int num = int.Parse(Console.ReadLine());
            bool flag = true;
            while(num>0)
            {
                int r = num % 10;
                if(r%2==0)
                {
                    flag = false;
                    break;
                }
                num = num / 10;
            }
            if(flag==true)
            {
                Console.WriteLine("Happy");
            }
            else 
            {
                Console.WriteLine("Not Happy");
            }
        }
    }
}
