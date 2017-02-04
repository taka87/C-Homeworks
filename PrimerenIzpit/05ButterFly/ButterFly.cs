using System;

class ButterFly
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char star = '*';
        char tire = '-';

        for (int j = 0; j < n - 2; j++)
        {
            if (j % 2 == 0)
            {
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(star);
                }
                Console.Write("\\ /");
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
            else if (j % 2 == 1)
            {
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(tire);
                }
                Console.Write("\\ /");
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(tire);
                }
                Console.WriteLine();
            }
        }
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(" ");
        }
        Console.Write("@");
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(" ");
        }
        Console.WriteLine();
        for (int j = 0; j < n - 2; j++)
        {
            if (j % 2 == 0)
            {
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(star);
                }
                Console.Write("/ \\");
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
            else if (j % 2 == 1)
            {
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(tire);
                }
                Console.Write("/ \\");
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(tire);
                }
                Console.WriteLine();
            }
        }
    }
}


//for (int i = 0; i < n - 2; i++)
//{
//    Console.Write(tire);
//}
//Console.Write("\\ /");
//for (int i = 0; i < n - 2; i++)
//{
//    Console.Write(tire);
//}
//Console.WriteLine();