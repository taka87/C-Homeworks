using System;
using System.Linq;

class MiddleElementsInArray
{
    static void Main()
    {
        int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        PrintMiddleElement(n);

        //Console.WriteLine(PrintMiddleElement(n));  // ??????????


        //int start = n.Length / 2 - 1;
        //int end = start + 2;
        //if (n.Length == 1)
        //{
        //    start = end = 0;
        //}
        //else if (n.Length % 2 == 0)
        //{
        //    end--;
        //}
        //int[] mid = new int[end - start + 1];

        //for (int i = 0; i < mid.Length; i++)
        //{
        //    mid[i] = n[start];
        //    Console.Write(mid[i] + " ");
        //    start++;
        //}
        //Console.WriteLine();
    }

    private static int[] PrintMiddleElement(int[] n)
    {
        int start = n.Length / 2 - 1;
        int end = start + 2;
        if (n.Length == 1)
        {
            start = end = 0;
        }
        else if (n.Length % 2 == 0)
        {
            end--;
        }
        int[] mid = new int[end - start + 1];

        for (int i = 0; i < mid.Length; start++, i++)
        {
            mid[i] = n[start];
            Console.Write(mid[i] + " ");
            //start++;
        }
        
        return mid;
    }
}