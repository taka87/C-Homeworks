using System;
using System.Linq;

class FoldAndSum
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] start = new int[nums.Length / 4];
        int[] end = new int[nums.Length / 4];
        int[] sum = new int[nums.Length / 2];
        int[] res = new int[nums.Length / 2];

        int count = 0;
        for (int i = 0; i < nums.Length / 4; i++)
        {
            start[i] = nums[i];
            end[i] = nums[nums.Length - i - 1];
        }
        Array.Reverse(start);

        for (int i = 0; i < start.Length * 2; i++)
        {
            if (i < start.Length)
            {
                sum[i] += start[i];
            }
            else
            {
                sum[i] += end[count];
                count++;
            }
        }

        for (int i = 0; i < res.Length; i++)
        {
            res[i] = sum[i] + nums[i + start.Length];
        }

        for (int i = 0; i < res.Length; i++)
        {
            Console.Write(res[i] + " ");
        }
    }
}