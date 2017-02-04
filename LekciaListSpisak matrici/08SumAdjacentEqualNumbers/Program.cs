using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<double> inputNums = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToList();

        int count = 0;

        List<double> result = new List<double>();

        for (int j = 0; j < count; j++)
        {
            for (int i = 0; i < inputNums.Count - 1; i++)
            {
                if (inputNums[i] == inputNums[i + 1])
                {
                    inputNums.RemoveAt(i);
                    inputNums[i] = 2 * inputNums[i];
                    //i--;
                    //result.Add(inputNums[i] + inputNums[i + 1]);
                }
                else
                {
                    continue;
                }
            }
            count++;
        }

        Console.WriteLine(string.Join(" ", inputNums));
    }
}