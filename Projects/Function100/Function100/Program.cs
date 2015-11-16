using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function100
{
    class Program

    {
        public static double howFar(double num1)
        {
            double answer = 100 - num1;

            if (answer < 0)
            {
                answer = answer * (-1);
            }
            return answer;
        }
          static void Main(string[] args)
        {
            
            Console.Write("Enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());

            while (num != 0)
            {
                Console.WriteLine(howFar(num));
                Console.Write("enter a number: ");
                num = Convert.ToDouble(Console.ReadLine());
            }

            

            
            

        }
    }
}
