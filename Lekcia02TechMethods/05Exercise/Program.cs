using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sumOfDigits = 0;
                int num = i;

                while (num > 0)
                {
                    sumOfDigits += i % 10;
                    num = num / 10;
                }

                bool isSpecial = sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;

                if (isSpecial)
                {
                    Console.WriteLine(i + " -> " + true);
                }
                else
                {
                    Console.WriteLine(i + " -> " + false);
                }
            }
        }
    }
}