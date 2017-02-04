using System;

class Exercise
{
    static void Main()
    {
        //string name = "Joro";
        //string age = "25";

        //string customtext = string.Format($"{name), age {age}");
        int n = 12;

        Console.WriteLine(n.ToString("X"));
        //Console.WriteLine(customtext);

        DateTime CurrentDate = DateTime.Now;
        Console.WriteLine(CurrentDate.ToString("yyyy-MM-dd hh.mm/ss"));  // formatirane na date time ...
    }
}