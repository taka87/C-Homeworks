using System;
using System.Globalization;
using System.Threading;

namespace _04PrintReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = "welcom softuni";
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("EN-us");

            double num = 325.333;
            // int num = 709825;

            //DateTime currentDate = DateTime.Now;
            DateTime currentDate = DateTime.ParseExact("01-05-2005", "dd-MM-yyyy", CultureInfo.InvariantCulture);

            string format = "dd/yyyy-MM";
            string str = string.Format("My number is equal to {0:C}!", num);
            string stringos = string.Format("My number is equal to {0:C}!", currentDate.ToString("dd-MM-yyyy"));
            string stringa = string.Format("My number is equal to {0:C}!", currentDate.ToString(format));

            Console.WriteLine(str);
            Console.WriteLine(currentDate);
            Console.WriteLine(stringos);
            Console.WriteLine("{0,20:F3}", 123.456465);  // formatira spaces v nachaloto
            Console.WriteLine("{0:D12}", 123);  // formatira spaces v nachaloto

        }
    }
}
