using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.ArrayDemo
{
    class FloatArrayDemo
    {
        static void Main(string[] args)
        {
            float[] floatArray = new float[5];

            floatArray[0] = 3.0f;
            floatArray[1] = 3.5F;
            floatArray[2] = 4.0f;
            floatArray[3] = 4.5F;
            floatArray[4] = 5.0F;

            float[] floatArray2 = { 1.0f, 1.5F, 2.0F, 2.5F, 3.0F };

            Console.WriteLine("Enter array Elements");
            foreach (float item in floatArray)
            {
                Console.Write("{0}", item);
            }

            Console.WriteLine();

            foreach (float item in floatArray2)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            

        }
    }
}
