using System;
using System.Collections.Generic;
using System.Linq;

namespace _14CountRealNumbers
{
    class CountRealNumbers
    {
        //dictionary link exercise    ! http://www.dotnetperls.com/sorteddictionary
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (double num in input)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }

            //for (int i = 0; i < counts.Count; i++)
            //{
            //    var element = counts.ElementAt(i);
            //    var key = counts.Keys;
            //    Console.WriteLine($"{element} -> {key}");
            //}

            foreach (var num in counts.Keys)
            {
                Console.WriteLine($"{num} -> {counts[num]}");
            }
        }
    }
}
