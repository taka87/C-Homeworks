using System;

class CalculateRadius
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:0.000000000000}", Math.PI * r * r);
        Console.WriteLine("{0:f12}", Math.PI * r * r);
    }
}