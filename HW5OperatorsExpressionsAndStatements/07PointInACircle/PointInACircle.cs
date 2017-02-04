using System;


class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2) <= Math.Pow(2, 2);

        Console.WriteLine(isInCircle);
    }
}
