using System;

class PointInACircle
{
    static void Main()
    {

        float x = float.Parse(Console.ReadLine());
        float y = float.Parse(Console.ReadLine());

        bool isInCircle = ((x * x) + (y * y) <= 2 * 2);

        Console.WriteLine(isInCircle);
    }
}

