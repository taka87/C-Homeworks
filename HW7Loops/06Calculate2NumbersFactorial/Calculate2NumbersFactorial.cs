using System;

class Calculate2NumbersFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int counter = 0;
        int counterSecond = 0;
        int nFactorial = 1;
        int kFactorial = 1;
        int result = 0;

        if (n > k)
        {
            counter = n;
            counterSecond = k;
        }
        else
        {
            counter = k;
            counterSecond = n;
        }

        for (int i = 1, j = 1; i <= counter; i++)
        {
            nFactorial = nFactorial * i;
            if (j <= counterSecond)
            {
                kFactorial = kFactorial * j;
            }
            j++;
        }
        result = nFactorial / kFactorial;

        Console.WriteLine(result);
    }
}