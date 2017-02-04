using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(' ');

            int[] nums = new int[command.Length];

            for (int i = 0; i < command.Length; i++)
            {
                nums[i] = int.Parse(command[i]);   // !!!!
            }

            foreach (var numbers in nums)
            {
                //int pesho = numbers++;  // ne raboti foreach readonly
                Console.WriteLine("{0}, ", numbers);
            }

            Console.WriteLine();
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
