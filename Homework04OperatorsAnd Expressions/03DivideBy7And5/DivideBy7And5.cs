using System;

class DivideBy7And5
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(n % 7 == 0 && n % 5 == 0 ? true : false);
    }
}

