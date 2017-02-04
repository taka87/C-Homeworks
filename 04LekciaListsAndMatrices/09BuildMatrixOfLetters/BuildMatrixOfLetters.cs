using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09BuildMatrixOfLetters
{
    class BuildMatrixOfLetters
    {
        static void Main(string[] args)
        {
            int wors = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            char[][] matrix = new char[wors][];

            for (int i = 0; i < wors; i++)
            {
                matrix[i] = new char[cols];  // vseki vlojen masiv kolko elementa ima
            }

            char filler = 'A';

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = filler;
                    filler++;
                }
            }


            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }

            //foreach (var row in matrix)
            //{
            //    Console.WriteLine(string.Join(" ", row));
            //}
        }
    }
}
