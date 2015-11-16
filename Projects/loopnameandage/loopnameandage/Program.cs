using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopnameandage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[3];
            int[] age = new int[3];

            // loop three times and get the name and age for each person
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("What is your name?");
                name[i] = Console.ReadLine();
                Console.WriteLine("What is your age?");
                age[i] = Convert.ToInt32(Console.ReadLine());


              
            }
        }
    }
}
