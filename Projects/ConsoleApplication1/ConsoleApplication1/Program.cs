using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This porgram was created by Angel
            at South Hills */ 
            Console.WriteLine("Hello World");
            Console.ReadKey();
            //Hey I used writeline below because I wanted the cursor on the next line
            Console.WriteLine("I'm Angel");
            Console.Write("What is your name?");
            string theirName;
            theirName = Console.ReadLine();
            Console.WriteLine("Hello " + theirName);
            Console.ReadKey();
            
        }
    }
}
