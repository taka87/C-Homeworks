﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CountLettersInString
{
    class CountLettersInString
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToLower().ToCharArray();
            Array.Sort(word);

            int counter = 1;

            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == word[i + 1])
                {
                    counter++;
                    if (i + 1 == word.Length - 1)
                    {
                        Console.WriteLine("{0} -> {1}", word[i], counter);
                    }
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", word[i], counter);
                    counter = 1;
                }
            }
        }
    }
}
