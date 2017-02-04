using System;
using System.Numerics;

namespace _07BigFactorial
{
    class BigFactorial
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger fact = 1;

            for (int i = number; i > 0; i--)
            {
                fact *= i;
            }

            Console.WriteLine(fact);
        }
    }
}
