using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? first = null;
        double? second = null;

        int num1 = 12;
        int num11 = 0;

        Console.WriteLine("{0}", first+num1);
        Console.WriteLine("{0}", first + num11);

        Console.WriteLine(second+num1);
        Console.WriteLine(second + num11);
    }
}