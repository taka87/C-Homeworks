using System;
using System.Linq;


namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine()
                               .Split(' ')
                               .Select(int.Parse)
                               .ToArray();
            int k = arr.Length / 4;

            int[] arr1 = new int[k * 2];
            int[] arr2 = new int[k * 2];
            int[] arrNew = new int[2 * k];
            int[] arrResult = new int[2 * k];

            var left = arr.Take(k).Reverse();
            var right = arr.Reverse().Take(k);

            arr1 = left.Concat(right).ToArray();
            arr2 = arr.Skip(k).Take(2 * k).ToArray();

            for (int i = 0; i < 2 * k; i++)
            {
                arrResult[i] = arr1[i] + arr2[i];
            }
            for (int i = 0; i < 2 * k; i++)
            {
                Console.Write("{0} ", arrResult[i]);
            }
        }
    }
}