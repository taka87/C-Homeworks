using System;
using System.Globalization;


class DayOfWeek
{
    static void Main()
    {
        string dateAsText = Console.ReadLine();

        DateTime date = DateTime.ParseExact(dateAsText, "d-MM-yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine(date.DayOfWeek);
    }
}