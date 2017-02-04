using System;
using System.Linq;

namespace _03Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] commandArgs = new int[size];

            for (int i = 0; i < commandArgs.Length; i++)
            {
                commandArgs[i] = int.Parse(Console.ReadLine());

            }
            int[] command = Console.ReadLine().Split(' ').Select(number => int.Parse(number)).ToArray(); // vrashta gi kato stringove
            //int[] command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // identichni sa vata reda

            Console.WriteLine(Sum(command));
            Console.WriteLine(MinValue(command));

            int last = command[command.Length - 1];

            Console.WriteLine(First(command));
            Console.WriteLine(Last(command));
            Console.WriteLine(Average(command));
            //int[] nums = new int[command.Length];


        }
        static double Average(int[] array)
        {
            int sumOfEllements = (int)Sum(array);

            return sumOfEllements / array.Length;
        }

        static int Last(int[] array)
        {
            return array[array.Length - 1];
        }

        static int First(int[] array)
        {
            return array[0];
        }

        static long Sum(int[] array)   // sumira podadenite parametri na masiva v daden red!
        {
            int sum = 0;

            foreach (var number in array)
            {
                sum += number;
            }

            return sum;
        }

        private static int MinValue(int[] numbers)
        {
            int min = int.MaxValue;

            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }

            return min;
        }
    }
}
