using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskGrades
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] grade = new int[3];
            
            
                Console.WriteLine("Hello, may I have your grade on test A? ");
                grade[0] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Can I have your grade for test B?");
                grade[1] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("And then your grade for test C?");
                grade[2] = Convert.ToInt32(Console.ReadLine());


            double total = grade[0] + grade[1] + grade[2];
            double average;

            average = total / grade.Length;
            Console.WriteLine("The average score is: " + average);
        }


          



            
      
        }




    }
    

