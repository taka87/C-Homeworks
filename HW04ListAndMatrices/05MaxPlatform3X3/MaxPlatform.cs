using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05MaxPlatform3X3
{
    class MaxPlatform
    {
        static void Main(string[] args)
        {
            List<int> MatrixDimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int row = MatrixDimentions[0];
            int col = MatrixDimentions[1];
            int[,] matrix = new int[row, col];
            long sum = 0;
            long maxsum = int.MinValue;
            int rowresult = 0;
            int colresult = 0;


            for (int i = 0; i < row; i++)
            {
                int[] coll = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = coll[j];
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sum = 0;
                    try
                    {
                        for (int i1 = i; i1 < i + 3; i1++)
                        {
                            for (int j1 = j; j1 < j + 3; j1++)
                            {
                                sum = sum + matrix[i1, j1];
                            }
                        }
                    }
                    catch
                    {
                        break;
                    }
                    if (sum > maxsum)
                    {
                        maxsum = sum;
                        rowresult = i;
                        colresult = j;
                    }
                }
            }
            Console.WriteLine(maxsum);
            for (int i = rowresult; i < rowresult + 3; i++)
            {
                for (int j = colresult; j < colresult + 3; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
