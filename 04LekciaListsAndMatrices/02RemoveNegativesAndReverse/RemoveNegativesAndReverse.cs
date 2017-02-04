using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNegativesAndReverse
{
    static void Main()
    {
        List<int> number = Console.ReadLine().Split().Select(int.Parse).Where(num => num >= 0).Reverse().ToList();

        Console.WriteLine(number.Count == 0 ? "empty" : string.Join(" ", number));
        if (number.Count == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine(string.Join(" ", number));
        }
    }
}