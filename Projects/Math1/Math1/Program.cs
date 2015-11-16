using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            a = 1;
            b = 2;
            c = 3;

            a = a + 1;
            b = c * a + b;
            c += (5 + a) - 1 * 5 + b; // c is now 13


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


        }
    }
}
