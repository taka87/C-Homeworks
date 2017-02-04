using System;

class FibonacciNumbers
{
    static int FibN(int fibNum)
    {
        int a = 0;
        int b = 1;

        for (int i = 0; i <= fibNum; i++)
        {
            int fibonacci = a;
            a = b;
            b = fibonacci + b;
        }
        return a;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(FibN(n));
    }
}