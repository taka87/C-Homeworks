using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_1._06._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            int[] size = { Convert.ToInt32(input[1]), Convert.ToInt32(input[2]) };

            switch (input[0].ToUpper())
            {
                case "A":
                    PrintMatrixA(size);
                    break;

                case "B":
                    PrintMatrixB(size);
                    break;

                case "C":
                    PrintMatrixC(size);
                    break;

                case "D":
                    PrintMatrixD(size);
                    break;
            }
        }

        static void PrintMatrixA(int[] size)
        {

            for (int rowA = 0; rowA < size[0]; rowA++)
            {
                int rowFirstNumber = rowA + 1;
                for (int colA = 0; colA < size[1]; colA++)
                {
                    Console.Write(rowFirstNumber + " ");
                    rowFirstNumber += 4;
                }
                Console.WriteLine();
            }
        }

        static void PrintMatrixB(int[] size)
        {
            for (int rowB = 0; rowB < size[0]; rowB++)
            {
                int rowFirstNumber = rowB + 1;
                for (int colB = 1; colB <= size[1]; colB++)
                {
                    if (colB == 1)
                    {
                        Console.Write(rowFirstNumber + " ");
                    }

                    if (colB % 2 == 0)
                    {
                        Console.Write(colB * size[0] - rowB + " ");
                    }

                    if (colB % 2 != 0 && colB > 1)
                    {
                        Console.Write(colB * size[0] - (size[0] - 1) + rowB + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void PrintMatrixC(int[] size)
        {

        }

        static void PrintMatrixD(int[] size)
        {
        }
    }
}