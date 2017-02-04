using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042X2SquaresInMatrixCOPyTOD
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dimention = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int row = dimention[0];
            int col = dimention[1];
            char[,] matrix = new char[row, col];
            int counter = 0;

            for (int i = 0; i < row; i++)
            {
                char[] colls = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = colls[j];
                }
            }


            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        try
                        {
                            if (matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i + 1, j] && matrix[i, j] == matrix[i + 1, j + 1])

                            {
                                counter++;
                            }
                        }
                        catch
                        {

                        }

                    }

                }
            }


            Console.WriteLine(counter);
            //  Print2D_MatrixChar(matrix);

        }
        static void Print2D_MatrixChar(char[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
