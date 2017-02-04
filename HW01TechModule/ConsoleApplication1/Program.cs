using System;
using System.Collections.Generic;
using System.Linq;

public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            string[] input = Console.ReadLine().Trim().Split(' ').ToArray();
            List<int> numbers = new List<int>();

            for (int j = 0; j < input.Length; j++)
            {
                if (!input[j].Equals(string.Empty))
                {
                    int num = int.Parse(input[j]);
                    numbers.Add(num);
                }
            }

            bool found = false;

            for (int k = 0; k < numbers.Count; k++)
            {
                int currentNum = numbers[k];

                if (currentNum >= 0)
                {
                    if (found)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(currentNum);

                    found = true;
                }
                else if (currentNum < 0)
                {
                    if (k != numbers.Count-1)
                    {
                        currentNum += numbers[k + 1];
                        //if (numbers[k + 1] < 0)
                        //{
                        //    currentNum -= numbers[k + 1];
                        //}
                        //else
                        //{
                        //    currentNum += numbers[k + 1];
                        //}
                    }
                    else
                    {
                        currentNum += 0;
                    }

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;

                    }
                    k++;
                }
            }

            if (!found)
            {
                Console.WriteLine("(empty)");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}