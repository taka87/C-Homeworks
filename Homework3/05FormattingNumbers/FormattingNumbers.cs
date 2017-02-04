﻿using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter an integer a:");
        int a = int.Parse(Console.ReadLine());
        if (a < 0 || a > 500)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        Console.WriteLine("Enter a floating-point b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a floating-point c:");
        double c = double.Parse(Console.ReadLine());

        Console.Write("|{0,-10}", Convert.ToString(a, 16).ToUpper());
        Console.Write("|{0,10}|",
        Convert.ToString(a, 2).PadLeft(10, '0'));
        string str = b.ToString();
        int index = str.IndexOf(".");
        if (index == -1)
        {
            Console.Write("{0,10}|", b);
        }
        else
        {
            Console.Write("{0,10:F2}|", b);
        }
        str = c.ToString();
        index = str.IndexOf(".");
        if (index == -1)
        {
            Console.Write("{0,-10}|", c);
        }
        else
        {
            Console.Write("{0,-10:F3}|", c);
        }
        Console.WriteLine();
    }
}

