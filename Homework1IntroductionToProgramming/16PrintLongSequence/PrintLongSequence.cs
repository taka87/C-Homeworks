using System;

class PrintLongSequence
{
    static void Main()
    {
        for (int i = 1; i < 1001; i++)
        {
            //Console.WriteLine(i);
            if (i % 2 == 0)
            {
                Console.Write(i);
                Console.Write(" ");

            }
            else
            {
                Console.Write(-i);
                Console.Write(" ");

            }
        }
    }
}

