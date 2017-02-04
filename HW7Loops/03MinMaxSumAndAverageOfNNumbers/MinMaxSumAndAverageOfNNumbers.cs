using System;
using System.Linq;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] nums = new int[n];
        int sum = 0;
        float avg = 0;

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("min = {0}", nums.Min());
        Console.WriteLine("max = {0}", nums.Max());
        sum = nums.Sum();
        avg = (float)sum / n;

        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:0.00}", avg); 
    }
}