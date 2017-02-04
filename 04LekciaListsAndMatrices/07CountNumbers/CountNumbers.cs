using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07CountNumbers
{
    public class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).OrderBy(n => n).ToList();


            int previousElement = numbers[0];
            int counter = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (previousElement == numbers[i])
                {
                    counter++;
                    if (i == numbers.Count-1)
                    {
                        Console.WriteLine($"{previousElement} -> {counter}");
                    }
                }
                else
                {
                    Console.WriteLine($"{previousElement} -> {counter}");
                    previousElement = numbers[i];
                    counter = 1;
                }
            }

            //Console.WriteLine($"{previousElement} -> {counter}");
        }
    }
}
