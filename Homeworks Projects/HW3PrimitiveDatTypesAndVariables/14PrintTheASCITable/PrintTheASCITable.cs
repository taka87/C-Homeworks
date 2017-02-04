using System;
using System.Text;

class PrintTheASCITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.ASCII;
        char ch = (char)1;
        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine("{0} --> {1}", i, ch);
            ch++;
        }
    }
}