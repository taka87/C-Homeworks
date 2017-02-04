using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Tour
{
    class Tour
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            
            int sum = 0;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                //read a matrix
                int[] celll = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    //pulnim posledovatelno vseki red na matricata s celll[j]
                    matrix[i, j] = celll[j];
                }
            }

            int[] destinations = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < destinations.Length; i++)
            {
                sum += matrix[count, destinations[i]];
                count = destinations[i];
            }

            Console.WriteLine(sum);
        }
    }
}
