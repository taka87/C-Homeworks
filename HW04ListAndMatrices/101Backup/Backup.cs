using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12BombNumberCopyTOD
{
    class BombNumberCopyTOD
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            int[] destinations = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            int count = 0;

            //chetem matrica
            for (int i = 0; i < n; i++)
            {
                int[] celll = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = celll[j];
                }
            }

            for (int i = 0; i < destinations.Length; i++)
            {
                sum = sum + matrix[count, destinations[i]];
                count = destinations[i];
            }

            Console.WriteLine(sum);
        }
    }
}