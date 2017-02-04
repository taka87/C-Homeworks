using System;
using System.Linq;

class SumMinMaxFirstLastAverage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(nums.Sum());
        Console.WriteLine(nums.Min());
        Console.WriteLine(nums.Max());
        Console.WriteLine(nums.First());
        Console.WriteLine(nums.Last());
        Console.WriteLine(nums.Average());
    }
}