using System;
using System.Linq;

class CurrencyCheck
{
    static void Main()
    {
        decimal r = uint.Parse(Console.ReadLine());
        decimal d = uint.Parse(Console.ReadLine());
        decimal e = uint.Parse(Console.ReadLine());
        decimal b = uint.Parse(Console.ReadLine());
        decimal m = uint.Parse(Console.ReadLine());

        decimal sumR = (r / 100) * 3.5m;
        decimal sumD = d * 1.5m;
        decimal sumE = e * 1.95m;
        decimal sumB = b / 2m;
        decimal sumM = m;

        decimal[] numbers = new decimal[] { sumR, sumD, sumE, sumB, m };
        decimal minNumber = numbers.Min();
        Console.WriteLine("{0:F2}", minNumber);
    }
}