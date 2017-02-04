using System;

class Program
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * (radius * radius);
        double perimeter = 2 * Math.PI * radius;

        Console.WriteLine("{0:F2}", perimeter);
        Console.WriteLine("{0:F2}", area);
       

    }
}