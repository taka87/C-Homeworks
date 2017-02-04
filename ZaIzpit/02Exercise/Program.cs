using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            int res = 0;
            string name = string.Empty;
            string nameRes = string.Empty;

            int sumLetter = 0;
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                //char[] input = Console.ReadLine().ToCharArray();
                string input = Console.ReadLine();
                int inputNum = int.Parse(Console.ReadLine());


                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] % 2 == 0)
                    {
                        sumLetter += input[j];
                    }
                    else
                    {
                        sumLetter -= input[j];
                    }
                    name += input[j];
                }
                sumLetter += inputNum;
                int a = result;
                result = sumLetter;

                if (a < result)
                {
                    nameRes = input;
                    res = result;
                }
                sumLetter = 0;
                result = 0;
            }

            Console.WriteLine("The winner is {0} - {1} points", nameRes, res);
        }
    }
}