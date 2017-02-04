using System;

    class ExtractBitFromInteger
{
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());

        int maskP = int.Parse(Console.ReadLine());

        int mask = 1;

        Console.WriteLine((n >> maskP) & mask);

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));

    }
}

