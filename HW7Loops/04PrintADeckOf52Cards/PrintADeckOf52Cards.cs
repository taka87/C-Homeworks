using System;

class PrintADeckOf52Cards
{
    static void Main()
    {

        string[] num = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        //string[] a = { "♠", "♥", "♣", "♦"};
        char[] a = { (char)5, (char)4, (char)3, (char)6 };

        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(num[i]+a[j]+" ");
            }
            Console.WriteLine();
        }
    }
}