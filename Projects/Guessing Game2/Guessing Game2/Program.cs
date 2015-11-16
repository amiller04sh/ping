using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int z = 1;
            Console.WriteLine("This is the guessing game!");


            Console.Write("Enter a number between 1 and 10: ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x == y)
            {
                
                Console.WriteLine("You have guessed the number correctly!");
            }
            else
            {
                while (y != x)
                {
                    Console.WriteLine("Sorry, you have guessed incorrectly.");
                    Console.WriteLine("Please guess again.");
                    y = Convert.ToInt32(Console.ReadLine());
                    z++;
                }
                Console.WriteLine("You have guessed the number correctly!");
                Console.WriteLine("It took you " + z + " times.");
                {
                  
                }

                }
            }
    }
}
