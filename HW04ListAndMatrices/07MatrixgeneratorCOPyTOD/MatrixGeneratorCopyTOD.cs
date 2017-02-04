using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07MatrixgeneratorCOPyTOD
{
    class MatrixGeneratorCopyTOD
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string type = input[0];
            int rows = int.Parse(input[1]);
            int cols = int.Parse(input[2]);
            int[,] matrix = new int[rows, cols];
            int i = 1;
            switch (type)
            {
                case "A":
                    TypeA(cols, rows, matrix, i);
                    break;
                case "B":
                    TypeB(cols, rows, matrix, i);
                    break;
                case "C":
                    TypeC(cols, rows, matrix, i);
                    break;
                case "D":
                    TypeD(cols, rows, matrix, i);
                    break;
            }
            Print(rows, cols, matrix);
        }
        private static void Print(int rows, int cols, int[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("" + matrix[row, col] + ' ');
                }
                Console.WriteLine();
            }
        }
        private static void TypeA(int cols, int rows, int[,] matrix, int i)
        {
            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    matrix[row, col] = i;
                    i++;
                }
            }
        }
        private static void TypeB(int cols, int rows, int[,] matrix, int i)
        {
            for (int col = 0; col < cols; col++)
            {
                if (col % 2 != 0)
                {
                    for (int row = rows - 1; row >= 0; row--)
                    {
                        matrix[row, col] = i;
                        i++;
                    }
                }
                else
                {
                    for (int row = 0; row < rows; row++)
                    {
                        matrix[row, col] = i;
                        i++;
                    }
                }
            }
        }
        private static void TypeC(int cols, int rows, int[,] matrix, int i)
        {
            for (int row = rows - 1; row >= 0; row--)
            {
                int startR = row;
                for (int col = 0; col < rows - startR; col++)
                {
                    if (col > cols - 1)
                    {
                        break;
                    }
                    matrix[startR + col, col] = i;
                    i++;
                }
            }
            for (int col = 1; col < cols; col++)
            {
                int startC = col;
                for (int row = 0; row < cols - startC; row++)
                {
                    if (row > rows - 1)
                    {
                        break;
                    }
                    matrix[row, startC + row] = i;
                    i++;
                }
            }
        }
        private static void TypeD(int cols, int rows, int[,] matrix, int i)
        {
            int indexR = 0;
            int indexC = 0;
            while (i <= rows * cols)
            {
                matrix[indexR, indexC] = i;
                i++;
                bool canGoDown = (indexR + 1) < rows && matrix[indexR + 1, indexC] == 0 && !((indexC - 1) >= 0 && matrix[indexR, indexC - 1] == 0);
                if (canGoDown)
                {
                    indexR++; continue;
                }
                bool canGoRight = (indexC + 1) < cols && matrix[indexR, indexC + 1] == 0;
                if (canGoRight)
                {
                    indexC++; continue;
                }
                bool canGoUp = (indexR - 1) >= 0 && matrix[indexR - 1, indexC] == 0;
                if (canGoUp)
                {
                    indexR--; continue;
                }
                bool canGoLeft = (indexC - 1) >= 0 && matrix[indexR, indexC - 1] == 0;
                if (canGoLeft)
                {
                    indexC--; continue;
                }
            }
        }
    }
}

