using System;

class AgeAfter10Years
{
    static void Main()
    {
        DateTime myYear = DateTime.Parse(Console.ReadLine());
        var now = float.Parse(DateTime.Now.ToString("yyyy.MMdd"));
        var dob = float.Parse(myYear.ToString("yyyy.MMdd"));
        var age = (int)(now - dob);

        Console.Write("Your Age is : ");
        Console.WriteLine(age);
        Console.Write("After 10 year your age will : ");
        Console.WriteLine(age + 10);
    }
}
