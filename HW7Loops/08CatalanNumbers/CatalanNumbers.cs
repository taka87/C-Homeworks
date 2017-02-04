using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger nTwoFact = 1;
        BigInteger nPlusFact = 1;
        BigInteger nFact = 1;

        for (int i = 1; i <= 2 * n; i++)
        {
            nTwoFact = nTwoFact * i;
        }
        for (int i = 1; i <= n + 1; i++)
        {
            nPlusFact = nPlusFact * i;
        }
        for (int i = 1; i <= n; i++)
        {
            nFact = nFact * i;
        }
        BigInteger res = nTwoFact / (nPlusFact * nFact);
        Console.WriteLine(res);
    }
}