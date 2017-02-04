using System;

class MoyaProgramaZaTEST
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 8, 7 };

        int sum = 0;
        for (int i = 0; i < 11; i++)
        {
            sum = arr[i % arr.Length];

            Console.Write(sum + " ");
        }
        Console.WriteLine();
        // string.join sazdava string i g razdelya s whitespace
        Console.Write(string.Join(" ", sum)); // tuk v posledniq zapis na sum ostava poslednata stoinost ot izvartane na cikala
        Console.WriteLine();
    }
}