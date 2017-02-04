using System;

class SunGlases
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n * 2; i++)
        {
            Console.Write("*");
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(" ");
        }
        for (int i = 0; i < n * 2; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("*");
            for (int j = 0; j < 2 * n - 2; j++)
            {
                Console.Write("/");
            }
            Console.Write("*");
            if (i == ((n - 1) / 2 - 1))
            {
                for (int l = 0; l < n; l++)
                {
                    Console.Write("|");
                }

            }
            else
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write(" ");
                }
            }
            Console.Write("*");
            for (int j = 0; j < 2 * n - 2; j++)
            {
                Console.Write("/");
            }
            Console.Write("*");
            Console.WriteLine();
        }

        for (int i = 0; i < n * 2; i++)
        {
            Console.Write("*");
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(" ");
        }
        for (int i = 0; i < n * 2; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}