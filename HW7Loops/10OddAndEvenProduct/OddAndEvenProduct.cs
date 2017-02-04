using System;
using System.Collections.Generic;

class OddAndEvenProduct
{
    static void Main()
    {

        string[] nums = Console.ReadLine().Split();

        int sumOdd = 1;
        int sumEven = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 2 == 0)
            {
                sumOdd *= Convert.ToInt32(nums[i]);
            }
            else
            {
                sumEven *= Convert.ToInt32(nums[i]);
            }
        }
        if (sumOdd == sumEven)
        {
            Console.WriteLine("yes\nproduct = {0}", sumEven);
        }
        else
        {
            Console.WriteLine("no\nodd_product = {0}\neven_product = {1}", sumOdd, sumEven);
        }
    }
}