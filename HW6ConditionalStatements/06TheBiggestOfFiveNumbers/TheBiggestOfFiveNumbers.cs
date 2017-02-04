using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine(a);
        }
        if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine(b);
        }
        if (c > b && c > b && c > d && c > e)
        {
            Console.WriteLine(c);
        }
        if (d > b && d > c && d > a && d > e)
        {
            Console.WriteLine(d);
        }
        if (e > b && e > c && e > d && e > a)
        {
            Console.WriteLine(e);
        }
    }
}
