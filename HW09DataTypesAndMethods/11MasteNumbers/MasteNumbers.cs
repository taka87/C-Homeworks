using System;

class MasteNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            if (IsPalindrome(i) && (SumOfDigits(i) % 7 == 0) && ContainsEvenDigit(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    private static bool ContainsEvenDigit(int i)
    {
        string digits = "" + i;

        for (int j = 1; j < digits.Length; j++)
        {
            int digit = digits[j] - '0';
            if (digits[j] == digits[digits.Length - j - 1])
            {
                return true;
            }
        }
        return false;
    }

    private static int SumOfDigits(int i)
    {
        int sum = 0;

        while (i > 0)
        {
            sum += i % 10;
            i = i / 10;
        }
        return sum;
    }

    private static bool IsPalindrome(int i)
    {
        string digits = "" + i;
        for (int j = 0; j < digits.Length / 2; j++)
        {
            if (digits[j] != digits[digits.Length - j - 1])
            {
                return false;
            }
        }
        return true;
    }
}