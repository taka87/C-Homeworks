using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03TargetMultiplier
{
    class TargetMultiplier
    {
        static void Main(string[] args)
        {
            int[] matrixLenght = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[][] matrix = new int[matrixLenght[0]][];

            //chetene na matrica
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[matrixLenght[1]];

                matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            int[] startMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int current = matrix[startMatrix[0]][startMatrix[1]];
            int sum = 0;

            for (int i = startMatrix[0] - 1; i < startMatrix[0] + 2; i++)
            {
                for (int j = startMatrix[1] - 1; j < startMatrix[1] + 2; j++)
                {
                    sum += matrix[i][j];
                    matrix[i][j] *= current;
                }
            }

            matrix[startMatrix[0]][startMatrix[1]] = (matrix[startMatrix[0]][startMatrix[1]]/current)*(sum-current);

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
            //Console.WriteLine(string.Join(" ", startMatrix));
        }
    }
}
