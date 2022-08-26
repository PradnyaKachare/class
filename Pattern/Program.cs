using System;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            for (int i = 1; i <= 3; i++)
=======
            /*for (int i = 1; i <= 3; i++)
>>>>>>> 0b5e1c57d7d859a0e38fc826885c0f53ff390293
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(j);
                }
<<<<<<< HEAD

            }
            Console.WriteLine("\n ----------------------------------");
=======
               
            }*/
>>>>>>> 0b5e1c57d7d859a0e38fc826885c0f53ff390293

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write("*");
                }
            }

            Console.WriteLine("\n ----------------------------------");


            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n ----------------------------------");


            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n ----------------------------------");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n ----------------------------------");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n ----------------------------------");


            for (int i = 1; i <= 4; i++)
            {
                for (int k = 4; k >= i; k--)
                {
                    Console.Write(" ");
                }
                    for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n ----------------------------------");


            for (int i = 4; i >=1; i--)
            {
                for (int k = i; k <= 4; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n ----------------------------------");


            for (int i = 4; i >= 1; i--)
            {
            
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n ----------------------------------");


            for (int i = 4; i >= 1; i--)                                                                            
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n ----------------------------------");

            for (char i = 'A'; i <= 'D'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n ----------------------------------");

            for (char i = 'A'; i <= 'D'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n ----------------------------------");



            for (char i = 'D'; i >= 'A'; i--)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n ----------------------------------");




            for (int i = 1; i <=4; i++)
            {
                if (i % 2 != 0)
                {
                    int c = 1;
                    for (char j = 'A';c<=i ; j++)
                    {   
                            Console.Write(j);
                        c++;
                    }
                } else
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }

        }

    }
}
