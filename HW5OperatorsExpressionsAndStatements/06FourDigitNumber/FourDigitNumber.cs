using System;

class FourDigitNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int d = (n / 1) % 10;
        int c = (n / 10) % 10;
        int b = (n / 100) % 10;
        int a = (n / 1000) % 10;


        int result = a + b + c + d;

        Console.WriteLine(result);
        Console.WriteLine(d + "" + c + b + a);
        Console.WriteLine(d + "" + a + b + c);
        Console.WriteLine(a + "" + c + b + d);
    }
}