﻿using System;
using System.Text;

class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        char ch = '\u00A9';

        Console.WriteLine("    {0}\n  {0}  {0}\n {0}    {0}\n{0}  {0} {0} {0}", ch);

        //Console.OutputEncoding = Encoding.UTF8;
        //char copyRight = (char)169;
        //int nCopyRight = 0;
        //do
        //{
        //    Console.WriteLine("The number of the copyright symbol is larger than 2:");
        //    Console.WriteLine("You must enter a number that is divisible by 3:");
        //    nCopyRight = int.Parse(Console.ReadLine());
        //    if (nCopyRight < 2)
        //    {
        //        Console.WriteLine("Number of copyright symbols is less than 2.");
        //        return;
        //    }
        //} while (nCopyRight % 3 != 0);
        //int count = 1;
        //string emptySpace = new string(' ', nCopyRight / 3);
        //Console.Write(emptySpace);
        //Console.Write("{0}", copyRight);
        //Console.Write(emptySpace);
        //Console.WriteLine();
        //for (int i = 1, j = 1; i < nCopyRight / 3; i++, j = j + 2)
        //{
        //    emptySpace = new string(' ', nCopyRight / 3 - i);
        //    Console.Write(emptySpace);
        //    Console.Write("{0}", copyRight);
        //    string emptySpaceMiddle = new string(' ', j);
        //    Console.Write(emptySpaceMiddle);
        //    Console.Write("{0}", copyRight);
        //    Console.Write(emptySpace);
        //    Console.WriteLine();
        //    count += 2;
        //}
        //for (int i = 0; i < nCopyRight - count; i++)
        //{
        //    Console.Write("{0}", copyRight);
        //    string emptySpaceDown = new string(' ', 1);
        //    Console.Write(emptySpaceDown);
        //}
        //Console.WriteLine();
    }
}