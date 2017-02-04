﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06HourglassSumCOPyTOD
{
    class HourGlasCopY
    {
        static void Main(string[] args)
        {
            int row = 6;
            int col = 6;
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
                                if ((i1 == i + 1 && j1 == j) || (i1 == i + 1 && j1 == j + 2))
                                {
                                    continue;
                                }
                                else
                                {
                                    sum = sum + matrix[i1, j1];
                                }
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
        }
    }
}