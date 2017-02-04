using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c = 0;

        Console.WriteLine("Before\na = {0}\nb = {1}", a, b);
        c = b;
        b = a;
        a = c;

        Console.WriteLine("After:\na = {0}\nb = {1}", a, b);
    }
}