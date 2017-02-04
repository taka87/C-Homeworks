using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int result = 1;
        int resultSecond = 2;
        int res = 0;

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                Console.Write("0 ");
            }
            else if (i == 1)
            {
                Console.Write("1 ");
            }
            else
            {
                res = result + resultSecond;

                Console.Write(result+" ");
                result = resultSecond;
                resultSecond = res;
            }            
        }
        Console.WriteLine();
    }
}