using System;
using System.Linq;

class Numbersreverse
{
    static void Main()
    {
        var nums = Console.ReadLine().
            Split().
            Select(int.Parse).
            ToArray();

        for (int i = 0; i < nums.Length/2; i++)
        {

        }
    }
}
