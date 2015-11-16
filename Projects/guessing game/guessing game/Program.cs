using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine("This is the guessing game!");
            Console.Write("Enter a number between 1 and 10: ");
            int y = Convert.ToInt32(Console.ReadLine());

            while (y == 5)
            {
                Console.WriteLine("You have guessed correctly!");
            }
            else
            {
                Console.WriteLine("I'm sorry, you have failed to guess correctly.");
            }

        }
    }
}
