﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int mostFrequent = numbers.GroupBy(value => value).OrderByDescending(group => group.Count()).First().Key;

            Console.WriteLine(mostFrequent);

        }
    }
}