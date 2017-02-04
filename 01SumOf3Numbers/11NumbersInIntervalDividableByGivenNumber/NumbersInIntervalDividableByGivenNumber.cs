using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.Write(counter + " : ");

        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}