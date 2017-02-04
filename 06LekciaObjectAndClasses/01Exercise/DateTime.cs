using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _01Exercise
{
    class DateTime
    {
        static void Main(string[] args)
        {
            List<System.DateTime> number = new List<System.DateTime>();

            for (int i = 0; i < 3; i++)
            {
                System.DateTime temp = System.DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
                number.Add(temp);
            }

            Console.WriteLine(string.Join(" ", number));
        }

        static void addDays()
        {

        }
    }
}
