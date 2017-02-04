using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int result = 0;

        n = n >> p;
        result = n & 1;

        if (result == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}