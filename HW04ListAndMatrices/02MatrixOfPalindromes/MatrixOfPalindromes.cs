using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int row = input[0];
            int col = input[1];

            char[][] ch = new char[row][];
            char firstLetter = 'a';

            for (char i = 'a'; i <= firstLetter + row - 1; i++)
            {
                for (char j = i; j < i + col; j++)
                {
                    string letters = i.ToString() + j.ToString() + i.ToString();

                    Console.Write(string.Join(" ",letters));
                    Console.Write(" ");
                    //Console.Write(ch[i]['a' + i]);
                    //Console.Write(ch[i]['a' + j]);
                    //Console.Write(ch[i]['a' + i]);
                }
                Console.WriteLine();
            }
        }
    }
}
