using System;

class Rectangles
{
    static void Main()
    {
        float weight = float.Parse(Console.ReadLine());
        float height = float.Parse(Console.ReadLine());

        float perimeter = (2 * weight) + (2 * height);
        float area = weight * height;

        Console.WriteLine("Perimeter = {0}, area = {1}", perimeter, area);

    }
}

