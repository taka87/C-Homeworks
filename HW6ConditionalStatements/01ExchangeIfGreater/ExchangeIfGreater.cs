using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        if (b > a)
        {
            Console.WriteLine(a + " " + b);
        }
        else
        {
            Console.WriteLine(b + " " + a);
        }
    }
}