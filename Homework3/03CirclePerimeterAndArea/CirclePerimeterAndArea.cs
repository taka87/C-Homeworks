using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter radius : ");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;

        Console.WriteLine("Perimeter = {0:0.00}, and Area = {1:0.00}", perimeter, area);
    }
}

