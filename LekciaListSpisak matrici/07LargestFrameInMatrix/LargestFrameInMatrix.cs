using System;
using System.Linq;
using System.Collections.Generic;

class LargestFrameInMatrix
{
    static void Main()
    {
        string[] sizes = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        int rows = int.Parse(sizes[0]);
        int cols = int.Parse(sizes[1]);

        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            string inputRow = Console.ReadLine();
            int[] rowParts = inputRow
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int j = 0; j < cols; j++)
            {

            }
        }
        IsMatrixWithSameNumberInBorders(matrix);
    }

    private static void IsMatrixWithSameNumberInBorders(int[,] matrix, int top, int left, int botton, int right)
    {
        int digit = matrix[top, left];

        for (int i = top; i < botton; i++)
        {
            if (i == top || i == botton)
            {
                for (int j = left; j < right; j++)
                {
                    if (matrix[i, j] != digit)
                    {
                        return false;
                    }
                }
            }
            else
            {
                if (matrix[i, left] != digit || matrix[i, right] != digit)
                {
                    return false;
                }
            }
            return true;
        }
    }
}