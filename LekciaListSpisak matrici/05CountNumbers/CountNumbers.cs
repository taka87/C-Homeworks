using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] count = new int[input.Max() + 1];

            foreach (var nums in input)
            {
                count[nums]++;
            }

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine($"{i} -> {count[i]}");
                }
            }
        }

    }
}
