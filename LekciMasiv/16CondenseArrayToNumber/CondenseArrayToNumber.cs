using System;
using System.Linq;

class CondenseArrayToNumber
{
    static void Main()
    {
        int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


        //int sum = 0;
        for (int i = 0; i <= num.Length; i++)
        {
            int[] condensed = new int[num.Length - 1];
            for (int j = 0; j < num.Length - 1; j++)
            {
                condensed[j] = num[j] + num[j + 1];

                //Console.Write(condensed[j] + " ");

            }
            num = condensed;
            //Console.WriteLine();
        }
        Console.WriteLine(num[0] + num[1]);
    }
}