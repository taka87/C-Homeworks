using System;

class ChrismasTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j < n - i; j++)
            {
                Console.Write(" ");
            }
            for (int l = 0; l < i; l++)
            {
                Console.Write("*");
            }
            Console.Write(" | ");
            for (int k = 0; k < i; k++)
            {
                Console.Write("*");

            }
            Console.WriteLine();
        }
    }
}
