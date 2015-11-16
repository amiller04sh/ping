using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age?");
            string myAge = Console.ReadLine();
            Console.WriteLine("Your age is " + myAge);
            int myAgeNum = Convert.ToInt32(myAge);
            int myAgeNumPlusFive = myAgeNum + 5;
            Console.WriteLine("In 5 years you will be " + myAgeNumPlusFive + " years old");


            Console.Write("What year were you born? ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You will be " + (2015 - birthYear) + " years old this year");


               
        }
    }
}
