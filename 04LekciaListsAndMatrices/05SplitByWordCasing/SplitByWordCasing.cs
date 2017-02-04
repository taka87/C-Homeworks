using System;
using System.Collections.Generic;

namespace _05SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            char[] delimeteres = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' };
            string[] words = Console.ReadLine().Split(delimeteres, StringSplitOptions.RemoveEmptyEntries);

            List<string> lower = new List<string>();
            List<string> upper = new List<string>();
            List<string> mixed = new List<string>();

            foreach (var word in words)
            {
                bool containtUpper = false;
                bool containtLower = false;
                //bool containsSymbol = false;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] >= 65 && word[i] <= 90)
                    {
                        containtUpper = true;

                    }
                    else if (word[i] >= 97 && word[i] <= 122)
                    {
                        containtLower = true;
                    }
                    //else
                    //{
                    //    containsSymbol = true;
                    //}
                }

                if (containtUpper)
                {
                    mixed.Add(word);
                }
                else if (containtLower)
                {
                    lower.Add(word);
                }
                else
                {
                    upper.Add(word);
                }
            }

            Console.WriteLine(string.Join(" ", lower));
            Console.WriteLine(string.Join(" ", mixed));
            Console.WriteLine(string.Join(" ", upper));
        }
    }
}
