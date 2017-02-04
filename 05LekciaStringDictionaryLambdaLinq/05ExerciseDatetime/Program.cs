using System;
using System.Globalization;

namespace _05ExerciseDatetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.ParseExact("11/1/5 12:00", "d/MM/yy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine(date);
        }
    }
}
