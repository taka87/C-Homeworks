using System;

class NumbersFromNTo1
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i > 0; i--)
        {
            Console.WriteLine(i);
        }
    }
}