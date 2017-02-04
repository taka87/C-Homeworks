using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07MatrixxGenerator
{
    class MatrixGenerator
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            char matrixSpecify = char.Parse(input[0]);
            int row = int.Parse(input[1]);
            int col = int.Parse(input[2]);

            int[][] matrix = new int[row][];

            //matrix A
            int matrixA = 1;

            //Matrix B
            int matrixB = 1;
            int matrixB1 = 0;
            matrixB1 += row * 2;

            //matrix C
            int count = 1;

            //Matrix A
            if (matrixSpecify == 'A')
            {
                for (int i = 0; i < row; i++)
                {
                    matrix[i] = new int[col];

                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] = matrixA;
                        Console.Write(matrix[i][j] + " ");
                        matrixA += row;
                    }
                    matrixA = i + 2;
                    Console.WriteLine();
                }
            }

            //Matrix B
            else if (matrixSpecify == 'B')
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    matrix[i] = new int[col];

                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (j % 2 == 0)
                        {
                            matrix[i][j] = matrixB;
                            Console.Write(matrix[i][j] + " ");
                            // matrixB += (matrix[i].Length - 1) * 2;
                            matrixB += row * 2;
                        }
                        else
                        {
                            matrix[i][j] = matrixB1;
                            Console.Write(matrix[i][j] + " ");
                            //matrixB += (matrix[i].Length - 1) * 2;
                            matrixB1 += row * 2;
                        }
                    }

                    matrixB = i + 2;
                    matrixB1 = row * 2 - i - 1;

                    Console.WriteLine();
                }
            }

            //matrix C
            else if (matrixSpecify == 'C')
            {
                //logic for half matrix
                for (int i = row - 1; i >= 0; i--)
                {
                    matrix[i] = new int[col];
                    int startR = i;

                    for (int j = 0; j < row - startR; j++)
                    {
                        if (j > col - 1)
                        {
                            break;
                        }
                        matrix[startR + j][j] = count;
                        count++;
                    }
                }

                //lofic for next half matrix 
                for (int i = 1; i < col; i++)
                {
                    int startC = i;
                    for (int j = 0; j < col - startC; j++)
                    {
                        if (j > row - 1)
                        {
                            break;
                        }
                        matrix[j][startC + j] = count;
                        count++;
                    }
                }

                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        Console.Write(matrix[i][j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            //matrixD 

            if (matrixSpecify == 'D')
            {
                int indexR = 0;
                int indexC = 0;
                int num = 0;

                //for (int i = 0; i < matrix.Length; i++)
                //{
                //    matrix[i] = new int[col];
                //    for (int j = 0; j < matrix[i].Length; j++)
                //    {
                //        matrix[i][j] = 0;
                //    }
                //}
                matrix[indexR] = new int[col];

                for (int k = 0; k < matrix.Length; k++)
                {
                    matrix[k] = new int[col];
                }

                while (num <= row * col)
                {
                    num++;
                    matrix[indexR][indexC] = num;

                    //Usloviqta proveryqvat na akde moje da se dviji chisloto ako num e po golqmo ot predhodnoto
                    //i se dviji v tazi posoka pri predvaritelno napravenata ot nas matrica - na koqto moje ako num e po malko ot predhodnoto
                                                                                              //tuk indexC e sazdadeno za da ne izlizame izvan matricata
                    bool canGoDown = (indexR + 1) < row && matrix[indexR + 1][indexC] == 0 && !((indexC - 1) >= 0 && matrix[indexR][indexC - 1] == 0);
                    if (canGoDown)
                    {
                        indexR++;
                        continue;
                    }

                    bool canGoRight = (indexC + 1) < col && matrix[indexR][indexC + 1] == 0;
                    if (canGoRight)
                    {
                        indexC++;
                        continue;
                    }

                    bool canGoUp = (indexR - 1) >= 0 && matrix[indexR - 1][indexC] == 0;
                    if (canGoUp)
                    {
                        indexR--;
                        continue;
                    }

                    bool canGoLeft = (indexC - 1) >= 0 && matrix[indexR][indexC - 1] == 0;
                    if (canGoLeft)
                    {
                        indexC--;
                        continue;
                    }
                }

                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        Console.Write(matrix[i][j] + " ");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
