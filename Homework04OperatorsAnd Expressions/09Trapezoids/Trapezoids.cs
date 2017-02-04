using System;

class Trapezoids
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float h = float.Parse(Console.ReadLine());

        float trArea = ((a + b )/ 2) * h;

        Console.WriteLine(trArea);
    }
}

