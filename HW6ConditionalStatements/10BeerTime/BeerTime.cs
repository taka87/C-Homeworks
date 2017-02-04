using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Enter time : ");
        string start = "1:00 PM";
        string end = "3:00 AM";
        DateTime startTime = DateTime.Parse(start);
        DateTime endTime = DateTime.Parse(end);

        try
        {
            DateTime dt = DateTime.Parse(Console.ReadLine());
            if (dt <= endTime || dt >= startTime)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("invalid input");
        }
    }
}