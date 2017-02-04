//using System;

//class House
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());

//        for (int i = 1; i <= (n + 1) / 2; i++)
//        {
//            for (int k = 1; k <= (n-i)/2; k++)
//            {
//                Console.Write("_ ");
//            }

//            if (n % 2 == 1)
//            {
//                // nechetno edna zvezdichka
//                int star = i;

//                for (int j = 0; j < star+2; j++)
//                {
//                    Console.Write("* ");
//                }
//            }
//            else
//            {
//                //chetno dve zvezdichki
//                int star = i + 1;

//                for (int j = 0; j < star+2; j++)
//                {
//                    Console.Write("* ");
//                }
//            }
//            for (int k = i; k <= (n + 1 - i) / 2; k++)
//            {
//                Console.Write("_ ");
//            }

//            Console.WriteLine();
//        }
//    }
//}


using System;

namespace house
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, j, k, n, l;

            n = int.Parse(Console.ReadLine());
            k = n % 2;

            if (k == 0)
            {
                for (i = 0; i < n / 2; i++)
                {
                    for (j = 1; j < n / 2 - i; j++)
                    {
                        Console.Write("-");
                    }
                    for (l = 0; l < i; l++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("**");
                    for (l = 0; l < i; l++)
                    {
                        Console.Write("*");
                    }
                    for (j = 1; j < n / 2 - i; j++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                for (i = 0; i < (n + 1) / 2; i++)
                {
                    for (j = 1; j < (n + 1) / 2 - i; j++)
                    {
                        Console.Write("-");
                    }
                    for (l = 0; l < i; l++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("*");
                    for (l = 0; l < i; l++)
                    {
                        Console.Write("*");
                    }
                    for (j = 1; j < (n + 1) / 2 - i; j++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }
            }
            if (k == 0)
            {
                for (i = 0; i < n / 2; i++)
                {
                    Console.Write("|");
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine("|");
                }
            }
            else
            {
                for (i = 0; i < (n - 1) / 2; i++)
                {
                    Console.Write("|");
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine("|");
                }

            }
        }
    }
}