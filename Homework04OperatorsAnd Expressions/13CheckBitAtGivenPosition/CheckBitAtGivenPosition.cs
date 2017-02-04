using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int maskP = int.Parse(Console.ReadLine());

        int mask = 1;

        int yesOrno = (n >> maskP) & mask;

        if (yesOrno == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

