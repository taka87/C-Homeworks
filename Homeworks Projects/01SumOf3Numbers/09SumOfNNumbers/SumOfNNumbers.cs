using System;

class SumOfNNumbers
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double result = 0;

        for (int i = 0; i < n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            result += number;
        }
        Console.WriteLine(result);
    }
}
