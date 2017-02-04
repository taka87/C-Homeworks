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
                //for (int j = 0; j < matrix[i].Length-1; j++)
                //{
                //    matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
                //}
            }


            // pechatane na amtrica
            for (int i = 0; i < matrix.Length; i++)
            {
                //matrix[i] = new int[matrixLenght[1]];

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ,");
                }
                Console.WriteLine();
            }

            // int[] startMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //Console.WriteLine(string.Join(" ", startMatrix));
        }
    }
}
