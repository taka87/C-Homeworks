using System;
using System.Numerics;

class Calculate2NumbersFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int counter = 0;
        int counterSecond = 0;
        int counterNK = 0;

        BigInteger nFactorial = 1;
        int kFactorial = 1;
        BigInteger nKFactorial = 1;

        if (n > k)
        {
            counter = n;
            counterSecond = k;
            counterNK = n - k;
        }
        else
        {
            counter = k;
            counterSecond = n;
            counterNK = k - n;
        }

        for (int i = 1, j = 1, l = 1; i <= counter; i++)
        {
            nFactorial = nFactorial * i;
            if (j <= counterSecond)
            {
                kFactorial = kFactorial * j;
            }
            if (l <= counterNK)
            {
                nKFactorial = nKFactorial * l;
            }
            l++;
            j++;
        }
        BigInteger result = nFactorial / (kFactorial * nKFactorial);

        Console.WriteLine(result);
    }
}