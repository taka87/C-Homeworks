using System;

class RandomizeThENumbersToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            int randomNumber = rnd.Next(n + 1);
            Console.Write("{0} ", randomNumber);
        }
        Console.WriteLine();
    }
}