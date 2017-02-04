using System;

class FibonaciiNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int fib1 = 0;
        int fib2 = 1;
        int fibonacci = 0;

        if (n == 0 || n == 1)
        {
            fibonacci = 1;
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                fibonacci = fib1 + fib2;
                fib1 = fib2;
                fib2 = fibonacci;
            }
        }
        Console.WriteLine(fibonacci);
    }
}