using System;

class PerimeterAndAreaCalculator
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());

        double catetFirs = a - c;
        double catetSecond = d - b;

        double area = catetFirs * catetSecond;
        double perimeter = 2 * (catetFirs + catetSecond);

        Console.WriteLine(area + "\n" + perimeter);
    }
}