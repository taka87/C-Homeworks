using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        DateTime start = DateTime.Parse(Console.ReadLine());
        DateTime end = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("{0}", DaysBetween(start,end));
    }
    static double DaysBetween(DateTime startDay, DateTime endDay)
    {
        TimeSpan days = startDay - endDay;

        double result = days.TotalDays;

        return result;
    }
}