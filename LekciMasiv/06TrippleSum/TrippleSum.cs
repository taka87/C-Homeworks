using System;
using System.Linq;

class TrippleSum
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        bool hasSum = false;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int a = nums[i];
                int b = nums[j];

                int sum = a + b;
                if (nums.Contains(sum)) //!! contains oznachava vklyuchva li ??
                {
                    hasSum = true;
                    Console.WriteLine($"{a} + {b} == {sum}");
                }
            }
        }

        if (!hasSum)
        {
            Console.WriteLine("No");
        }
    }
}