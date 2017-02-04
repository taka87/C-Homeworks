using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayMatcher
{
    class ArrayMatcher
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputSplitted = input.Split('\\');

            char[] leftChar = inputSplitted[0].ToCharArray();
            char[] rightChar = inputSplitted[1].ToCharArray();
            List<char> output = new List<char>();


            if (inputSplitted[2] == "join")
            {
                for (int i = 0; i < leftChar.Length; i++)
                {
                    if (rightChar.Contains(leftChar[i]))
                    {
                        output.Add(leftChar[i]);
                    }
                }
            }
            else if (inputSplitted[2] == "right exclude")
            {
                for (int i = 0; i < leftChar.Length; i++)
                {
                    if (!rightChar.Contains(leftChar[i]))
                    {
                        output.Add(leftChar[i]);
                    }
                }
            }
            else if (inputSplitted[2] == "left exclude")
            {
                for (int i = 0; i < rightChar.Length; i++)
                {
                    if (!leftChar.Contains(rightChar[i]))
                    {
                        output.Add(rightChar[i]);
                    }
                }
            }

            output.Sort();
            foreach (var item in output)
            {
                Console.Write(item);
            }
        }
    }
}