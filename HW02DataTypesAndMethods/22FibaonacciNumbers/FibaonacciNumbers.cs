using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22FibaonacciNumbers
{
    class FibaonacciNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Fibonacci(num);
        }

        private static void Fibonacci(int num)
        {
            int fib0 = 1;
            int fib1 = 1;

            for (int i = 0; i < num-1; i++)
            {
                int number = fib0 + fib1;
                fib0 = fib1;
                fib1 = number;
            }

            Console.WriteLine(fib1);
        }
    }
}
