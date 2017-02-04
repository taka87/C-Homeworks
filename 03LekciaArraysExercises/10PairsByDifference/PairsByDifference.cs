using System;
using System.Linq;

class Pairs
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int[] value = new int[input.Length / 2];

        for (int i = 0, counter = 0; i < input.Length; i += 2, counter++)
        {
           value[counter] = input[i] + input[i + 1];
        }

        if (value.All(x => x == value.First()))
        {
            Console.WriteLine("Yes, value = {0}", value.First());
        }
        else
        {
            int maxDiff = -1;
            for (int i = 0; i < value.Length - 1; i += 2)
            {
                int currentDiff = Math.Abs(value[i] - value[i + 1]);
                maxDiff = Math.Max(maxDiff, currentDiff);
            }

            Console.WriteLine(0);
        }
    }
}