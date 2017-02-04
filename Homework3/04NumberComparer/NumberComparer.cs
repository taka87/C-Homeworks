using System;

class NumberComparer
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());

        double result = Math.Max(a, b);
        Console.WriteLine(result);
    }
}

