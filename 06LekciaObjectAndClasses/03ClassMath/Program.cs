using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ClassMath
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = Math.Pow(int.Parse(Console.ReadLine()), 2);
            Console.WriteLine(num);

            double power = Math.Pow(5, 2);
            Console.WriteLine(power);
        }
    }
}
