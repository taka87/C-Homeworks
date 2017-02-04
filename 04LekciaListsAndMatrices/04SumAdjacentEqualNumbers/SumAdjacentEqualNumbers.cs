using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();

            bool hasEqual = true;

            while (hasEqual)
            {
                hasEqual = false;

                for (int i = 0; i < input.Count - 1; i++)
                {
                    if (input[i] == input[i + 1])
                    {
                        input[i] *= 2;
                        input.RemoveAt(i + 1);
                        hasEqual = true;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
