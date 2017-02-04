using System;

class DaysOfWeek
{
    static void Main()
    {
        string[] daysOfWeek =
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday", "Friday",
            "Saturday",
            "Sunday"
        };

        int days = int.Parse(Console.ReadLine());

        if (days <= 7 && days >= 1)
        {
            Console.WriteLine(daysOfWeek[days - 1]);
        }
        else
        {
            Console.WriteLine("Invalid day!");
        }
    }
}
