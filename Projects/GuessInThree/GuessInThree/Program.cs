using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessInThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rmd = new Random();
            int x = rmd.Next(1, 11);
            int y;

            Console.WriteLine("Guess in Three");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Guess a number between 1 and 10: ");
                y = Convert.ToInt32(Console.ReadLine());
            }
           
        }
    }
}
            
         
       
