using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> input = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            string firstchange = string.Empty;
            string secondchange = string.Empty;

            for (int i = 0; i < 100000; i++)
            {
                string[] dircestions = Console.ReadLine().Split().ToArray();

                if (dircestions[0] == "end")
                {
                    break;
                }

                else if (dircestions[0] == "decrease")
                {
                    for (int j = 0; j < input.Count; j++)
                    {
                        input[j] = input[j] - 1;
                    }
                }
                else
                {
                    int first = int.Parse(dircestions[1]);
                    int second = int.Parse(dircestions[2]);

                    if (dircestions[0] == "swap")
                    {

                        int a = (int)input[first];
                        int b = (int)input[second];

                        if (second > first)
                        {
                            input.RemoveAt(second);
                            input.RemoveAt(first);
                        }
                        else
                        {
                            input.RemoveAt(first);
                            input.RemoveAt(second);
                        }

                        if (second > first)
                        {

                            input.Insert(first, b);
                            input.Insert(second, a);
                        }
                        else
                        {
                            input.Insert(second, a);
                            input.Insert(first, b);

                        }

                    }
                    else if (dircestions[0] == "multiply")
                    {
                        long multiply = input[first] * input[second];

                        input.RemoveAt(first);
                        input.Insert(first, multiply);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}