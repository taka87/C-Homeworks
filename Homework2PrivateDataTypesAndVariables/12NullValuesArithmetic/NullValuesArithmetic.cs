using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? i = null;
        double? d = null;

        Console.WriteLine(i);
        Console.WriteLine(d);
        Console.WriteLine(i + 3);
        Console.WriteLine(d + 3);
        Console.WriteLine(i + null);
        Console.WriteLine(d + null);
    }
}

