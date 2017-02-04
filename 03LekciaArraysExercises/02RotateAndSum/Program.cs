using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] sum = new int[input.Length];
            int[] result = new int[input.Length];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = input[i];
            }

            //result = sum;

            int lastElement = input[input.Length - 1];

            for (int j = 0; j < k; j++)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (i == input.Length - 1)
                    {
                        input[0] = lastElement;
                        //input[i+1] += sum[i];
                    }
                    else
                    {
                        input[input.Length - 1 - i] = input[input.Length - 2 - i];
                        //input[0] += sum[0];
                    }
                }

                for (int l = 0; l < sum.Length; l++)
                {
                    result[l] += input[l];
                }
                lastElement = input[input.Length - 1];
            }

            Console.WriteLine(string.Join(" ", input));
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
