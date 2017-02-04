using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DiagonalDifferenceCOPyTOD
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];


            for (int i = 0; i < n; i++)
            {
                int[] colums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = colums[j];
                }
            }
            int dif = 0;
            int d1 = SumOfdiagonals1(matrix);
            int d2 = SumOfdiagonals2(matrix);
            dif = Math.Abs(d2 - d1);

            Console.WriteLine(dif);
        }
        static int SumOfdiagonals1(int[,] a)
        {
            int sumd1 = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                sumd1 = sumd1 + a[i, i];
            }
            return sumd1;
        }
        static int SumOfdiagonals2(int[,] a)
        {
            int sumd1 = 0;
            for (int i = a.GetLength(0) - 1; i >= 0; i--)
            {
                sumd1 = sumd1 + a[i, a.GetLength(0) - 1 - i];

            }
            return sumd1;
        }
    }
}