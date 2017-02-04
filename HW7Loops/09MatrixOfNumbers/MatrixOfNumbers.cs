using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int res = 0 + i;
            for (int j = 1; j <= n; j++)
            {
                Console.Write(res + " ");
                res++;
            }
            Console.WriteLine();
        }
    }
}