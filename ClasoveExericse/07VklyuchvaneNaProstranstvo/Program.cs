using System;

namespace _07VklyuchvaneNaProstranstvo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<int> ints = new System.Collections.Generic.List<int>();
            System.Collections.Generic.List<double> doubles = new System.Collections.Generic.List<double>();

            while (true)
            {
                int intResult;
                double doubleResult;
                Console.WriteLine("Enter an integer or double : ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out intResult))
                {
                    ints.Add(intResult);
                }
                else if (double.TryParse(input, out doubleResult))
                {
                    doubles.Add(doubleResult);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("You entered {0} ints", ints.Count);

            foreach (var i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("You entered {0} doubles", doubles.Count);

            foreach (var n in doubles)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
