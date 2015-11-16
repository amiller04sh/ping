using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic8ball
{
    class Program
    {

        public static void answer()
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 6);

            if (x == 1)
            {
                Console.WriteLine("Outlook not good");
            }
            if (x == 2)
            {
                Console.WriteLine("Try again later");
            }
            if (x == 3)
            {
                Console.WriteLine("Highly unlikely");
            }
            if (x == 4)
            {
                Console.WriteLine("Signs point to yes");
            }
            if (x == 5)
            {
                Console.WriteLine("Most definitley");
            }
        

        }


        static void Main(string[] args)
        {
            Console.Write("Enter your question.");
            Console.ReadLine();
            answer();

        
        }
    }
}
