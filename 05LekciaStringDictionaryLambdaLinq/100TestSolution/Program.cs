using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100TestSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            // първоначално декларираме само брой редове, тъй като колоните могат да са с различна дължина

            // и се съхраняват в отделен масив

            int[][] matrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray(); //  прочитаме информацията
            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));  //  отпечатваме информацията

            }
        }
    }
}
