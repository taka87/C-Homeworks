using System;

class CalculateNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int factorial = 1;
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
            sum += factorial / Math.Pow(x, i);
        }
        Console.WriteLine("{0:0.00000}", sum);
    }
}