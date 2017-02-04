﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Pairs
{
    class Pairs
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (Math.Abs(input[i] - input[j]) == number)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}