using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int maskP = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        int newMask = 1;
        int realSum = n;

        if (v == 0)
        {
            v = 1;
        }
        else
        {
            v = 0;
        }

        newMask = (n >> maskP) & v;

        n = n & (newMask << maskP);

        realSum = realSum ^ n;

        Console.WriteLine(realSum);

        //Console.WriteLine(Convert.ToString(newMask, 2).PadLeft(16, '0'));
        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        //Console.WriteLine(Convert.ToString(realSum, 2).PadLeft(16, '0'));
    }
}

