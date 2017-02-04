using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c;

        Console.WriteLine("Int a value = {0}, and int b value = {1}", a,b);

        c = b;
        b = a;
        a = c;

        Console.WriteLine("After changing int a = {0}, int b = {1}", a,b);


    }
}

