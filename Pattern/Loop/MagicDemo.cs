using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Loop
{
    class MagicDemo
    {
        static void Main(string[] args)
        {
            int magic_no = 56;

            while (true)
            {
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());

                if (num > magic_no)
                {
                    Console.WriteLine("Entered number is Greater than Magic number pls try Again...");
                    continue;
                }
                else if (num < magic_no)
                {
                    Console.WriteLine("Entered number is Less than Magic number pls try Again...");
                    continue;
                }
                else
                {
                    Console.WriteLine("you r guess Correct");
                    break;
                }
            }
        }
    }
}
