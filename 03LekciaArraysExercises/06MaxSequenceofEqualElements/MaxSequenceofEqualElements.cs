using System;
using System.Linq;

namespace _06MaxSequenceofEqualElements
{
    class MaxSequenceofEqualElements
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = 1;
            int bestSum = 1;
            int bestLen = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    counter++;

                    if (bestSum < counter)
                    {
                        bestSum = counter;
                        bestLen = input[i];
                    }
                }
                else
                {
                    counter = 1;
                }

                if (bestSum == 1)
                {
                    bestLen = input[0];
                }
            }

            for (int i = 0; i < bestSum; i++)
            {
                Console.Write(bestLen + " ");
            }

            //Console.WriteLine(bestStart);     
        }
    }
}
