using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Write positive int lower than 100 = ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (number > 0 && number <= 100)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }

            }
            Console.WriteLine(isPrime);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

