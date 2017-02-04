using System;

class SumOf5Numbers
{
    static void Main()
    {
        string line = Console.ReadLine();
        var numbers = line.Split(' ');
        double result = 0;

        foreach (var number in numbers)
        {
            double num;
            if (double.TryParse(number, out num))
            {
                result += num;
                // num is your number as integer
            }
        }
        Console.WriteLine(result);
    }
}