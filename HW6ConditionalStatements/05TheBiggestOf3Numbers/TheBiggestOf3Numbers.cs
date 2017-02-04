using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine(a);
        }
        else if (a > b && a < c)
        {
            Console.WriteLine(c);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine(b);
        }
        else if (b > c && b < a)
        {
            Console.WriteLine(a);
        }
        else if (c > a && b < c)
        {
            Console.WriteLine(c);
        }
        else if (c > b && a > c)
        {
            Console.WriteLine(a);
        }

    }
}