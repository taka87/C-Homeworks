using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNegatives
{
    static void Main()
    {
        List<int> inputNums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        for (int i = 0; i < inputNums.Count; i++)
        {
            if (inputNums[i] < 0)
            {
                inputNums.RemoveAt(i);
                i--;
            }
        }

        //inputNums.Reverse();
        //Console.WriteLine(string.Join(" ", inputNums));

        if (inputNums.Count == 0)
        {
            Console.WriteLine("Empty");
        }
        else
        {
            inputNums.Reverse();
            Console.WriteLine(string.Join(" ", inputNums));
        }

        //for (int i = 0; i < inputNums.Count; i++)
        //{
        //    if (i == inputNums.Count - 1)
        //    {
        //        Console.Write(inputNums[i] + " ");
        //    }

        //}
        //Console.WriteLine();
    }
}