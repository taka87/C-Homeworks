using System;
using System.Collections.Generic;
using System.Linq;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> numbers = new List<int>();
            List<int> repeats = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (numbers.Contains(input[i]))
                {
                    continue;
                }
                else if (numbers.Contains(input[i]) == false)
                {
                    numbers.Add(input[i]);
                    repeats.Add(1);
                    for (int j = i + 1; j < input.Length; j++)
                    {
                        if (numbers.Last() == input[j])
                        {
                            repeats[repeats.Count - 1]++;
                        }
                    }
                }
            }
            int index = repeats.IndexOf(repeats.Max());
            Console.WriteLine(numbers[index]);
        }
    }
}