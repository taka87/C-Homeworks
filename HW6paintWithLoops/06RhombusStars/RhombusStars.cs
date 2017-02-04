using System;


//http://www.dotnetfunda.com/articles/show/2031/print-diamond-of-stars-and-diamond-space-in-square
// razlichni rombove

class rectanglesOf10Stars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            for (int i = 0; i < n - row; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            for (int i = 0; i < row - 1; i++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }

        for (int i = 1; i < n - 1; i++)
        {
            for (int k = 0; k < i - 1; k++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
            if (i == n - 2)
            {
                for (int l = 0; l < n - 1; l++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
        }
        if (n == 2)
        {
            Console.WriteLine(" *");
        }
    }
}

//using System;

//namespace DiamondPattern
//{
//    class DiamondPattern
//    {
//        static void Main()
//        {
//            int n = Convert.ToInt32(Console.ReadLine());
//            for (int i = 1; i <= n; i++)
//            {
//                for (int j = 0; j < (n - i); j++)
//                    Console.Write(" ");
//                for (int j = 1; j <= i; j++)
//                    Console.Write("*");
//                for (int k = 1; k < i; k++)
//                    Console.Write(" *");
//                Console.WriteLine();
//            }
//            for (int i = n - 1; i >= 1; i--)
//            {
//                for (int j = 0; j < (n - i); j++)
//                    Console.Write(" ");
//                for (int j = 1; j <= i; j++)
//                    Console.Write("*");
//                for (int k = 1; k < i; k++)
//                    Console.Write("*");
//                Console.WriteLine();
//            }
//        }
//    }
//}