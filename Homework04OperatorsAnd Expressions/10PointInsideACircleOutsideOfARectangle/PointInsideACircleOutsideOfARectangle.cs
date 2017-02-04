using System;

class PointInsideACircleOutsideOfARectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        //(x - center_x) ^ 2 + (y - center_y) ^ 2 < radius ^ 2.

        //bool isInCircle = (((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= 1.5 * 1.5);
        bool isInCircle = (Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2) <= 1.5 * 1.5);

        bool isInRectangle = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);

        if (isInCircle && !isInRectangle)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

