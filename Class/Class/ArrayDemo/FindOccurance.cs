using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.ArrayDemo
{
    class FindOccurance
    {
        public static void Frequency(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i - 1; k >= 0; k++)
                {
                    if (a[i] == a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = 0; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(a[i] + "" + count);

                    if (count==1)                                       //Unique Element display
                    {
                        Console.WriteLine(a[i] + "" + count);       
                    }
                    if (count > 1)                                      //Duplicate Element display
                    {
                        Console.WriteLine(a[i] + "" + count);
                    }

                }

            }  
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the array Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            FindOccurance.Frequency(arr);


        }
    }
}
