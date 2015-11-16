using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        public static void myTime()
        {
            Console.WriteLine("Hello World! The time is " + DateTime.Now);
        }
        public static void myPersonalTime(string theirName)
        {
            Console.WriteLine("Hello " + theirName + "! The time is " + DateTime.Now);
        }

        public static void isItEven(int myNumber)
        {
            if ((myNumber % 2) == 0)
            {
                Console.WriteLine(myNumber + ":It is Even!");
            }
            else
            {
                Console.WriteLine(myNumber + ":It is Odd!");
            }
        }

        public static void addMyNumbers(int num1, int num2)
        {
            int total = num1 + num2;
            Console.WriteLine("The total is: " + total);
        }

        public static double addThenMultiply(double num1, double num2)
        {
            double total = num1 + num2;
            total *= 2;
            return total;
        }

        static void Main(string[] args)
        {
            /*
            myTime();
            myPersonalTime("Angel");

            Console.Write("Enter your name ");
            string yourName = Console.ReadLine();
            myPersonalTime(yourName);
            */


            Console.WriteLine("Please pick a number.");
            int theirNum = Convert.ToInt32(num1);
            Console.WriteLine(isItEven);


            addMyNumbers(5, 11);

            double myTotal = addThenMultiply(5, 7);
            Console.WriteLine(myTotal);
           
        }
    }
}

