using System;
using System.Collections.Generic;


namespace _23PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            string numbers = string.Join(", ", IsPrime(start, end).ToArray());

            Console.WriteLine(numbers);

        }

        private static List<int> IsPrime(int start, int end)
        {
            bool isPrime = true;

            List<int> primes = new List<int>();

            // int num = (int)Math.Sqrt(end);

            if (start <= 1 && end > 1)
            {
                start = 2;
            }
                for (int i = start; i <= end; i++)
                {
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            //break;
                        }
                    }
                    if (isPrime)
                    {
                        primes.Add(i);
                    }
                    isPrime = true;
                }
            //}
            return primes;
        }
    }
}
