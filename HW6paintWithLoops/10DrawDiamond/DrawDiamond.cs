//using System;

//class DrawDiamond
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());

//        int tire = 1;
//        int tire2 = 2;

//        int firstParth = 0;
//        int secondPart = 1;

//        int tireSecondPart = n / 2;
//        int tireSecond = 0;


//        if (n % 2 == 1)
//        {
//            firstParth = (n / 2) + 1;
//            tireSecond = n - 4;
//        }
//        else
//        {
//            firstParth = n / 2;
//        }

//        for (int i = 0; i < n; i++)
//        {

//            if (i == 0)
//            {
//                for (int j = 0; j < ((n - 1) / 2) - i; j++)
//                {
//                    Console.Write("-");
//                }

//                if (i == 0 && n % 2 == 1)
//                {
//                    Console.Write("*");
//                }
//                else if (i == 0 && n % 2 == 0)
//                {
//                    Console.Write("**");
//                }

//                for (int j = 0; j < ((n - 1) / 2) - i; j++)
//                {
//                    Console.Write("-");
//                }
//                Console.WriteLine();
//            }

//            if (i >= 1 && i < firstParth)
//            {
//                for (int j = 0; j < ((n - 1) / 2) - i; j++)
//                {
//                    Console.Write("-");
//                }

//                Console.Write("*");

//                if (n % 2 == 0)
//                {
//                    for (int k = 0; k < tire2; k++) // otpechatvane na srednite chertichki
//                    {
//                        Console.Write("-");
//                    }
//                }
//                else
//                {
//                    for (int k = 0; k < tire; k++)
//                    {
//                        Console.Write("-");
//                    }

//                }

//                Console.Write("*");

//                for (int j = 0; j < ((n - 1) / 2) - i; j++)
//                {
//                    Console.Write("-");
//                }
//                Console.WriteLine();
//                tire += 2;
//                tire2 += 2;
//            }
//            ///////////////////////////////////////////

//            if (i >= firstParth && i < n - 1)
//            {
//                if (i == firstParth)
//                {
//                    tire -= 3;
//                    tire2 -= 3;
//                }
//                tire -= 2;
//                tire2 -= 2;
//                for (int j = 0; j < secondPart; j++)
//                {
//                    Console.Write("-");
//                }

//                Console.Write("*");

//                if (n % 2 == 0)
//                {
//                    for (int k = 0; k < tire; k++) // otpechatvane na srednite chertichki
//                    {
//                        Console.Write("-");
//                    }
//                }
//                else
//                {
//                    for (int k = 0; k < tire2; k++)
//                    {
//                        Console.Write("-");
//                    }

//                }

//                Console.Write("*");

//                for (int j = 0; j < secondPart; j++)
//                {
//                    Console.Write("-");
//                }
//                Console.WriteLine();



//                secondPart++;
//            }

//            if (i == n - 1)
//            {
//                for (int j = 0; j < ((n - 1) / 2); j++)
//                {
//                    Console.Write("-");
//                }

//                if (i == n - 1 && n % 2 == 1)
//                {
//                    Console.Write("*");
//                }
//                else if (i == n - 1 && n % 2 == 0)
//                {
//                    Console.Write("**");
//                }

//                for (int j = 0; j < ((n - 1) / 2); j++)
//                {
//                    Console.Write("-");
//                }
//                //Console.WriteLine();

//            }
//            Console.WriteLine();
//        }
//    }
//}


using System;

namespace Diamond
{
    class Diamand
    {
        static void Main(string[] args)
        {

            int i, k, n;
            n = int.Parse(Console.ReadLine());
            k = n % 2;

            if (n == 1)
            {
                Console.WriteLine("*");
            }
            else if (k != 0 && n != 1)
            {
                Console.Write(new string('-', (n - 1) / 2));
                Console.Write("*");
                Console.Write(new string('-', (n - 1) / 2));
                Console.WriteLine();

                for (i = 0; i < (n - 1) / 2; i++)
                {
                    Console.Write(new string('-', (n - 1) / 2 - i - 1));
                    Console.Write("*");
                    Console.Write(new string('-', n - (n - i - (i + 1))));
                    Console.Write("*");
                    Console.Write(new string('-', (n - 1) / 2 - i - 1));
                    Console.WriteLine();
                }
                for (i = 0; i < (n - 1) / 2 - 1; i++)
                {
                    Console.Write(new string('-', i + 1));
                    Console.Write("*");
                    Console.Write(new string('-', n - (2 * (i + 2))));
                    Console.Write("*");
                    Console.Write(new string('-', i + 1));
                    Console.WriteLine();
                }
                Console.Write(new string('-', (n - 1) / 2));
                Console.Write("*");
                Console.Write(new string('-', (n - 1) / 2));
                Console.WriteLine();

            }

            else
            {
                {
                    for (i = 0; i < n / 2; i++)
                    {
                        Console.Write(new string('-', n / 2 - i - 1));
                        Console.Write("*");
                        Console.Write(new string('-', 2 * i));
                        Console.Write("*");
                        Console.Write(new string('-', n / 2 - i - 1));
                        Console.WriteLine();
                    }
                    for (i = 0; i < n / 2 - 1; i++)
                    {
                        Console.Write(new string('-', i + 1));
                        Console.Write("*");

                        Console.Write(new string('-', n - 4 - 2 * i));

                        Console.Write("*");
                        Console.Write(new string('-', i + 1));
                        Console.WriteLine();
                    }
                }
            }

        }
    }
}