using System;
using System.Linq;

class MassiveReverse
{
    static void Main()
    {
        var nums = Console.ReadLine()
              .Split(' ')
              .Select(int.Parse)
              .ToArray();

        int[] reverse = new int[nums.Length];

        for (int i = 0; i < nums.Length / 2; i++)
        {
            SwapElements(nums, i, nums.Length - 1 - i);

            //reverse[reverse.Length - 1 - i] = nums[i];
            //Console.WriteLine(string.Join(", ", reverse));

        }
        Console.WriteLine(string.Join(" ", nums));

    }
    public static void SwapElements(int[] arr, int i, int j)
    {
        var oldElements = arr[i];
        arr[i] = arr[j];
        arr[j] = oldElements;
    }
}