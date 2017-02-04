using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = 0;
            int bestStart = 0;
            int bestLen = 0;
            int startPos = 0;

            for (int i = 1; i <= input.Length -1; i++)
            {
                if (input[i] - input[i - 1] >= 1)
                {
                    counter++;
                    bestStart = i - counter;

                    if (counter > bestLen)
                    {
                        bestLen = counter;
                        startPos = bestStart;
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            for (int i = startPos; i <= startPos + bestLen; i++)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}
