using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storingmultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            // this program takes three names and ages
            // and outputs three

            string[] name = new string[3];
            int[] age = new int[3];

            // first name
            Console.WriteLine("What is your name?");
            //name = Console.ReadLine();
            name[0] = Console.ReadLine();
            // first age
            Console.WriteLine("What is your age?");
            age[0] = Convert.ToInt32(Console.ReadLine());
            // output name and age
            
            Console.WriteLine("Name 1 is: " + name[0]);
            Console.WriteLine("Age 1 is: " + age[0]);
            
            // second name
            Console.WriteLine("What is your name?");
            //name = Console.ReadLine();
            name[1] = Console.ReadLine();
            //second age
            Console.WriteLine("What is your age?");
            age[1] = Convert.ToInt32(Console.ReadLine());
            // output name and age

            
            Console.WriteLine("Name 2 is: " + name[1]);
            Console.WriteLine("Age 2 is: " + age[1]);

            // third name
            Console.WriteLine("What is your name?");
            //name = Console.ReadLine();
            name[2] = Console.ReadLine();
            // third age
            Console.WriteLine("What is your age?");
            age[2] = Convert.ToInt32(Console.ReadLine());
            // output name and age

            // output:
            Console.WriteLine("Name 3 is: " + name[2]);

        }
    }
}
