using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = 0;
            int[] output = new int[input.Length / 2];

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (i < input.Length / 4)
                {
                    output[i] = input[input.Length / 4 - i - 1] + input[input.Length / 4 + i];
                }
                else
                {
                    output[i] = input[input.Length / 2 + counter] + input[input.Length - counter - 1];
                    counter++;
                }
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
