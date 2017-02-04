
using System;

class ThirdDigitIs7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        float result = n / 100;
        float result1 = result % 10;

        Console.WriteLine(result1 == 7 ? true : false);

    }
}

