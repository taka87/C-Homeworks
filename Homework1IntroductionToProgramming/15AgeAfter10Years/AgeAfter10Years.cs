﻿using System;
using System.Globalization;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Enter your year of Birth:");
        string yearBirth = Console.ReadLine();
        string format = "yyyy";
        DateTime dateTime;
        int myBirthYear = int.Parse(yearBirth);
        if (DateTime.TryParseExact(yearBirth, format, CultureInfo.InvariantCulture,
            DateTimeStyles.None, out dateTime))
        {
            DateTime today = DateTime.Now;
            if (today.Year <= myBirthYear)
            {
                myBirthYear--;
            }
            int myYearsNow = today.Year - myBirthYear;

            // add the 10 years to today's date
            DateTime future = today.AddYears(10);

            // add your year to future
            DateTime futurYear = future.AddYears(myYearsNow);

            // now subtract them to get your age in 10 years from now 
            int fa = futurYear.Year - today.Year;

            Console.WriteLine("Your age now: {0}", myYearsNow);
            Console.WriteLine("\nIn 10 years you will be:");
            Console.WriteLine(fa);
        }
    }
}
