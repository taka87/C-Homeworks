using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> result = new List<int>();

        if (startNum < 2)
        {
            startNum = 2;
        }

        for (int i = startNum; i <= endNum; i++)
        {
            bool isPrime = true;

            for (int j = 2; (j * j) <= i; j++)  //j*j <= i !
            {
                if ((i % j) == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime == true)
            {
                result.Add(i);
            }
        }
        return result;
    }
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        List<int> ranger = FindPrimesInRange(start, end);

        if (start > end)
        {
            Console.WriteLine("empty list");
        }
        else
        {
            //string numbers = String.Join(", ", FindPrimesInRange(start, end).ToArray());

            for (int i = 0; i < ranger.Count; i++)
            {
                Console.WriteLine("{0}", ranger[i]);
            }
        }
    }
}