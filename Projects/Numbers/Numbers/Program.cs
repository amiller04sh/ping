using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Byte Min = " + byte.MinValue);
            Console.WriteLine("Byte Max = " + byte.MaxValue);
            Console.WriteLine("Byte size = " + sizeof(byte) + " bytes");

            Console.WriteLine("Int Min = " + int.MinValue);
            Console.WriteLine("Int Max = " + int.MaxValue);
            Console.WriteLine("Int size = " + sizeof(int) + " bytes");

            Console.WriteLine("Uint Min = " + uint.MinValue);
            Console.WriteLine("Uint Max = " + uint.MaxValue);
            Console.WriteLine("Uint size = " + sizeof(uint) + " bytes");

            Console.WriteLine("Ulong Min = " + ulong.MinValue);
            Console.WriteLine("Ulong Max = " + ulong.MaxValue);
            Console.WriteLine("Ulong size = " + sizeof(ulong) + " bytes");

            Console.WriteLine("Double Min = " + double.MinValue);
            Console.WriteLine("Double Max = " + double.MaxValue);
            Console.WriteLine("Double size = " + sizeof(double) + " bytes");

            float fpi = 3.1415926535897932384626433832f;
            Console.WriteLine("Pi is " + fpi);

            double dpi = 3.1415926535897932384626433832;
            Console.WriteLine("Pi is " + dpi);

            decimal decpi = 3.1415926535897932384626433832m;
            Console.WriteLine("Pi is " + decpi);





        }
    }
}
