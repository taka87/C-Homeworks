using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());

        byte mask = 1;

        Console.WriteLine((n >> 3) & mask);

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));

    }
}

