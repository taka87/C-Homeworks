using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //int blurAmmount = int.Parse(Console.ReadLine());
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            long[,] matrix = new long[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] columns = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = columns[col];
                }
            }

            int[] cordinatesToBlur = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rowToBlur = cordinatesToBlur[0];
            int colToBlur = cordinatesToBlur[1];
            long element = 0;



            int startRow = Math.Max(0, rowToBlur - 1);
            int endRow = Math.Min(rows - 1, rowToBlur + 1);

            int startCol = Math.Max(0, colToBlur - 1);
            int endCol = Math.Min(cols - 1, colToBlur + 1);

            for (int row = startRow; row <= endRow; row++)
            {
                for (int col = startCol; col <= endCol; col++)
                {
                    if (row != rowToBlur || col != colToBlur)
                    {
                        element += matrix[row, col];
                        matrix[row, col] = matrix[row, col] * matrix[rowToBlur, colToBlur];
                    }
                }
            }
            matrix[rowToBlur, colToBlur] *= element;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
            //Console.WriteLine(matrix[rowToBlur,colToBlur]);
            //Console.WriteLine(element);
        }
    }
}
