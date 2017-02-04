using System;

class Pyramid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int k = 0;

        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= i; j++)
            {

                k += 1;
                Console.Write(k + " ");
                if (k == n)
                {
                    break;
                }
            }
            Console.WriteLine();
            if (k == n)
            {
                break;
            }
        }
    }
}