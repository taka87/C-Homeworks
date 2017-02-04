using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ArrayModifier
{
    class ArrayModifier
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();

            string[] command = Console.ReadLine().Split().ToArray();



            while (command[0] != "end")
            {
                string command1 = command[0];
                int index1 = 0;
                int index2 = 0;

                if (command.Length >= 2)
                {
                    index1 = int.Parse(command[1]);
                    index2 = int.Parse(command[2]);
                }

                if (command1 == "swap")
                {
                    input = SwapInts(input, index1, index2);
                    //Console.WriteLine(string.Join(" ",  input));
                }
                else if (command1 == "multiply")
                {
                    input[index1] = input[index1] * input[index2];
                    //Console.WriteLine(string.Join(" ",  input));
                }
                else if (command1 == "decrease")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        input[i] -= 1;
                        //if (input[i] < 0)
                        //{
                        //    input[i] = input[i] - (-1);
                        //}
                        //else
                        //{
                        //    input[i] = input[i] - 1;
                        //}
                    }
                    //Console.WriteLine(string.Join(" ", input));
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(", ", input));
        }

        static long[] SwapInts(long[] array, long position1, long position2)
        {
            //
            // Swaps elements in an array. Doesn't need to return a reference.
            //
            long temp = array[position1]; // Copy the first position's element
            array[position1] = array[position2]; // Assign to the second element
            array[position2] = temp; // Assign to the first element

            return array;
        }
    }
}
