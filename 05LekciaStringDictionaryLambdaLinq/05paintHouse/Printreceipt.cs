using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05paintHouse
{
    class Printreceipt
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            Console.WriteLine("/----------------------\\");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("| {0,20:F2} |", numbers[i]);
            }

            Console.WriteLine("|{0}|", new string('-', 22));
            Console.WriteLine("| Total:{0,14:F2} |",numbers.Sum());

            Console.WriteLine(@"\----------------------/");
        }
    }
}
