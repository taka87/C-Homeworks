
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21reversedNums
{
    class reversedNums
    {
        static void Main(string[] args)
        {

            string nums = Console.ReadLine();

            ReversedNums(nums);
        }

        private static void ReversedNums(string numbers)
        {
            for (int i = numbers.Length-1; i >= 0; i--)
            {
                Console.Write(numbers[i]);
            }
        }
    }
}
