using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _14DateTimeFormat
{
    class DateTimeFormat
    {
        static void Main(string[] args)
        {
            string text = "01.09.2016";

            DateTime parsedate = DateTime.Parse(text);

            Console.WriteLine(parsedate);

            //nov primer
            string date = "16.05.2016";

            string format = "dd.MM.yyyy";

            DateTime parseDate = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);

            Console.WriteLine("Day: {0}\nMonth: {1}\nYear: {2}", parseDate.Day, parseDate.Month, parseDate.Year);
        }
    }
}
