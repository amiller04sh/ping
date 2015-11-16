using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age?");
            string theirAge = Console.ReadLine();
            Console.Write("Your age is" + theirAge);
            Console.Write(". What is your lucky number?");
            string theirNum = Console.ReadLine();
            int theirAgeNum = Convert.ToInt32(theirAge);
            int theirFavNum = Convert.ToInt32(theirNum);
            int theirNumTogether = theirAgeNum + theirFavNum;
            Console.WriteLine("Your age and favorite number added together is " + theirNumTogether);
            Console.ReadLine();
            Console.WriteLine("Your first number was {0} and your second was {1} with the total of {2}", theirAgeNum, theirFavNum, theirNumTogether);
            Console.ReadLine();
           

     
          

        }
    }
}
