using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameandAge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the arrays
            string[] name = new string[3];
            int[] age = new int[3];


            for (int i = 0; i < 3; i++)
            {
                Console.Write("What is your name? ");
                name[0] = Console.ReadLine();
                Console.Write("Hello {0}, what is your age? ", name[0]);
                age[0] = Convert.ToInt32(Console.ReadLine());
            }
             // Print the array data to the screen
            for (int i = 0; i <=2; i++)
            {
              Console.WriteLine(name[i] + ":" + age[i]);
            }
        }
           
        }
    }

