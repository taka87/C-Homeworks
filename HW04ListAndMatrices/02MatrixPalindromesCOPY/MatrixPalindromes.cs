using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02MatrixPalindromesCOPY
{
    class MatrixPalindromes
    {
        static void Main(string[] args)
        {
            List<int> inputDimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int row = inputDimentions[0];
            int col = inputDimentions[1];
            char[,,] tesaract = new char[row, col, 3];
            // Console.WriteLine("{0} {1}", row, col);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (k == 1)
                        {
                            tesaract[i, j, k] = (char)(97 + j + i);
                        }
                        else
                        {
                            tesaract[i, j, k] = (char)(97 + i);
                        }

                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {

                        Console.Write("{0}", tesaract[i, j, k]);
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
