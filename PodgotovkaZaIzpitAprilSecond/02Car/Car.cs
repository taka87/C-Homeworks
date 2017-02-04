using System;

class Car
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int num = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write(".");
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write("*");
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(".");
        }
        Console.WriteLine();

        for (int i = 1; i < n / 2; i++)
        {
            for (int j = 0; j < n - i; j++)
            {
                Console.Write(".");

            }
            Console.Write("*");
            for (int k = 0; k < n + num; k++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int j = 0; j < n - i; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();

            num += 2;
        }


        for (int i = 0; i < (n + 2) / 2; i++)
        {
            Console.Write("*");
        }
        for (int i = 0; i < (n * 2 - 2); i++)
        {
            Console.Write(".");
        }
        for (int i = 0; i < (n + 2) / 2; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();

        for (int i = 0; i < (n - 4) / 2; i++)
        {
            Console.Write("*");
            for (int j = 0; j < (n * 3) - 2; j++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            Console.WriteLine();
        }

        for (int i = 0; i < n * 3; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();

        for (int i = 0; i < (n - 4) / 2; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int k = 0; k < (n - 2) / 2; k++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int l = 0; l < n - 2; l++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int m = 0; m < (n - 2) / 2; m++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int o = 0; o < n / 2; o++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }

        for (int o = 0; o < n / 2; o++)
        {
            Console.Write(".");
        }
        for (int i = 0; i < (n + 2) / 2; i++)
        {
            Console.Write("*");
        }
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(".");
        }
        for (int i = 0; i < (n + 2) / 2; i++)
        {
            Console.Write("*");
        }

        for (int o = 0; o < n / 2; o++)
        {
            Console.Write(".");
        }
        Console.WriteLine();
    }
}