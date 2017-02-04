using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05NewStringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 42;
            Console.WriteLine(number.ToString("D5")); // 00042
            Console.WriteLine(number.ToString("X"));  // 2A
                                                      // Consider the default culture is U.S.
            Console.WriteLine(number.ToString("C")); // $42.00


            double d = 0.375;
            Console.WriteLine(d.ToString("P2")); // 37.50 %
            Console.WriteLine(d.ToString("F2")); // 0.38
            Console.WriteLine("Now is {0:d.MM.yyyy HH:mm:ss}", DateTime.Now); // Now is 31.11.2009 11:30:32


            //              Some format strings for numbers:
            //              D – number(for integer types)
            //              F – fixed point (for real numbers)
            //              X – hexadecimal number
            //              C – currency(according to current culture)
            //              P – percentage
            //              Format strings for date and time formatting:
            //              d, dd, M, MM, yy, yyyy, h, hh, H, HH, m, mm, s, ss, t


        }
    }
}
