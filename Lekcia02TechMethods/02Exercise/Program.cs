using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int century = int.Parse(Console.ReadLine());

            int year = century * 100;
            int days = (int)(year * 365.2422);
            int hours = 24 * days;
            int minutes = hours * 60;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes",
                century, year,days,hours,minutes);
        }
    }
}
