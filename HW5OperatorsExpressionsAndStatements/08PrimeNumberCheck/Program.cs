using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if (isPrime(n) == 0)
        {
            Console.WriteLine(false);
        }
        else
        {
            Console.WriteLine(true);
        }
    }
    static int isPrime(int n)
    {
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0 && i != n)
            {
                return 0;
            }
        }
        return 1;
    }
}