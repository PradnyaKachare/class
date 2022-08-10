using System;

namespace SwitchDemo2
{
                                               //Calculator


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());

           // Console.WriteLine("1.Addition\n2.Substraction\n3.Multiplication\n4.Division");

            /*Console.WriteLine("Enter Your Choice:");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Addition="+(num1+num2));
                    break;

                case 2:
                    Console.WriteLine("Substraction=" + (num1 - num2));
                    break;

                case 3:
                    Console.WriteLine("Multiplication=" + (num1 * num2));
                    break;

                case 4:
                    Console.WriteLine("Division=" + (num1 / num2));
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;*/




                    //By using Operator



                    char opr = Convert.ToChar(Console.ReadLine());

                    switch (opr)
                    {
                        case '+':
                            Console.WriteLine("Addition=" + (num1 + num2));
                            break;

                        case '-':
                            Console.WriteLine("Substraction=" + (num1 - num2));
                            break;

                        case '*':
                            Console.WriteLine("Multiplication=" + (num1 * num2));
                            break;

                        case '/':
                            Console.WriteLine("Division=" + (num1 / num2));
                            break;

                        default:
                            Console.WriteLine("Invalid Choice");
                            break;

                    }



        }
    }
}
