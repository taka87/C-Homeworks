using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int result = 0;
            //int[] nums = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                result += Reverce(input[i]);
            }

            Console.WriteLine(result);
            //Console.WriteLine(string.Join(" ", nums));
        }

        static int Reverce(int num)
        {
            //obrashta cifrichkite v chisoto 123 -> 321 
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }

            return result;
        }
    }
}
