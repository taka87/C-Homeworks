using System;

class Stepeni
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num = 4;


        for (int i = 1; i <= n; i++)
        {
            if (i == 1)
            {
                Console.WriteLine("1");
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine(num);

                num = num * 4;
            }
        }
    }
}