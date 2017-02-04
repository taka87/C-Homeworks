using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05CondenseArrayToNum
{
    class Program
    {
        static void Main(string[] args)
        {
           // int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (numbers.Length > 1)
            {
                int[] con = new int[numbers.Length - 1];
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    con[i] = numbers[i] + numbers[i + 1];
                }
                numbers = con;
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
