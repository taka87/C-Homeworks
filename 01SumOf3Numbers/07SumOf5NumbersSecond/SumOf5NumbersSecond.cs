using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SumOfNumbers
{
    static void Main()
    {
        string myString = Console.ReadLine();

        string[] ssizes = myString.Split();

        double[] numbers = Array.ConvertAll(ssizes, double.Parse);

        double sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine(sum);
    }
}