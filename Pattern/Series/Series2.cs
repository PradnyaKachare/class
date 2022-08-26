using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Series   //2 , 3, 5,9,17,33 , 65, generate first n numbers of above series. Input : 5 Output : 67 3 + 5 + 9 + 17 + 33 = 67
{                       //  2+1=3 2+3= 5 5+4 =9  9+8 =17 17+16 =33 33+32 =65 65+64 =129 129+128 =257 
    class Series2
    {
        static int calculateSum(int n)
        {
            // Sn = n*(4*n*n + 6*n - 1)/3

            return ((int)Math.Pow(2, n + 1) + n - 2);
        }

        // Driver Code
        static void Main(string[] args)
       
        {
            // number of terms to // be included in sum
            int n = 4;

            // find the Sn
            Console.WriteLine("Sum = " + calculateSum(n));
        }
    }
}
