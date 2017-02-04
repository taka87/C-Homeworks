using System;
using System.Numerics;

class Bigfactorial
{
    static void Main()
    {
        int factorial = int.Parse(Console.ReadLine());

        Console.WriteLine(FactorialCalc(factorial));
    }

    static BigInteger FactorialCalc(int factorial)
    {

        BigInteger sum = 1;

        for (int i = 2; i <= factorial; i++)
        {
            sum *= i;
        }

        return sum;
    }
}