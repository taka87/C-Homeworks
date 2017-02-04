using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16LargestThreeNumbers
{
    class LargestThreeNumbers
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();

            input.Sort();

            int count = 0;

            if (input.Count<3)
            {
                count = input.Count;
            }
            else
            {
                count = 3;
            }
            for (int i = input.Count-1; i > input.Count-count-1; i--)
            {
                Console.Write($"{input[i]} ");
            }


            ////reshenieto tuk e s 4 reda
            //List<int> input = Console.ReadLine().Split().Select(x=>int.Parse(x)).ToList();

            //IOrderedEnumerable<int> sortedNums = input.OrderBy(x => -x);

            //IEnumerable<int> largest3Nums = sortedNums.Take(3);

            //Console.WriteLine(string.Join(" ", largest3Nums));
        }
    }
}
