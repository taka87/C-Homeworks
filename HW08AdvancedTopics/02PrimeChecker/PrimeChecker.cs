using System;

class PrimeChecker
{
    static bool IsPrime(long number)
    {
        long newNum = number;
        bool result = true;

        for (int i = 2; i <= Math.Sqrt(newNum); i++)
        {
            if ((newNum % i) != 0)
            {
                result = true;
            }
            else if ((newNum % i) == 0)
            {
                result = false;
                break;
            }
        }

        return result;
    }
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        if (IsPrime(n) == false) // declare if statement for print false not False
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
        }
    }
}