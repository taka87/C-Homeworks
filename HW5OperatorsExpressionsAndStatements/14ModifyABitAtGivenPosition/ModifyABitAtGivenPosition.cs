using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());

        int copy = n;

        if (v == 0)
        {
            int result = ~(1 << p);
            int finalResult = n & result;
            Console.WriteLine(finalResult);
        }
        else if (v == 1)
        {
            int result = 1 << p;
            int finalResult = (n | result);
            Console.WriteLine(finalResult);
        }
        //______________________________________________________ DRUGO RESHENIE
        //int mask = 1 << p;
        //int numberAndMask = n & mask;
        //int bit = numberAndMask >> p;

        //if (bit != v)
        //{
        //    if (v == 1)
        //    {
        //        n = n | mask;
        //    }
        //    else //if(v == 0)
        //    {
        //        n = n & ~mask;
        //    }
        //}
        //Console.WriteLine("n = {0}", n);
        //-----------------------------------------------DRUGO RESHENIE S STRINGS
        //Console.Write("Enter your number: ");
        //int number = int.Parse(Console.ReadLine());
        //Console.Write("Check bit of position: ");
        //int position = int.Parse(Console.ReadLine());
        //Console.Write("Value of bit [0 or 1]: ");
        //int value = int.Parse(Console.ReadLine());

        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));

        //if (value == 1)
        //{
        //    int setOne = 1 << position;
        //    int foundBitOne = number | setOne;
        //    Console.WriteLine(Convert.ToString(foundBitOne, 2).PadLeft(16, '0'));
        //    Console.WriteLine(foundBitOne);
        //}
        //else
        //{
        //    int setZero = ~(1 << position);
        //    int foundBitZero = number & setZero;
        //    Console.WriteLine(Convert.ToString(foundBitZero, 2).PadLeft(16, '0'));
        //    Console.WriteLine(foundBitZero);
        }
    }
}