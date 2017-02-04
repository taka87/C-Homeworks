using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int n = int.Parse(Console.ReadLine());

        int[] sum = new int[input.Length];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < input.Length - 1; j++)
            {
                if (j == 0)
                {
                    sum[j] += input.Last();
                }
                else
                {
                    sum[j] += input[j - 1];
                }
            }
        }

        for (int i = 0; i < sum.Length; i++)
        {
            Console.WriteLine(sum[i]);
        }
    }
}