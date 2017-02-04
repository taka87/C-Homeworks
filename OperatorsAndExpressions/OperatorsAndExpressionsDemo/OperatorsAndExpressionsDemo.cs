using System;

class OperatorsAndExpressionsDemo
{
    static void Main()
    {
        //int a = 5;
        //int b = 2;

        //int result = 4;

        //Console.OutputEncoding = Encoding.UTF8;
        //Console.WriteLine(Math.Pow(result));

        short a1 = 3;
        short b1 = 5;

        Console.WriteLine(Convert.ToString(a1, 2).PadLeft(16, '0'));
        Console.WriteLine(Convert.ToString(a1, 2).PadLeft(16, '0'));
        Console.WriteLine(Convert.ToString(a1 | b1, 2).PadLeft(16, '0'));

        int weekFlags = 49;
        byte mask = 1;

        //00110001 >> 2
        //00000001

        Console.WriteLine((weekFlags >> 2) & mask);
        Console.WriteLine((weekFlags >> 4) & mask);
         
        //00110001
        //00000001 << 4
        //00010000 ~ 
        //11101111 &

        //int weekFlags = 49;
        int maska = ~(1<<4);
        int readMask = 1;

        weekFlags = weekFlags & maska;

        Console.WriteLine((weekFlags>>4)&readMask);
        
    }
}

