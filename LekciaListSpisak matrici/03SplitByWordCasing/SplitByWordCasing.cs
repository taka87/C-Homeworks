using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            char[] separators = new char[]
             { ',', ';', ':', '.', '!', ' ', '(', ')', '"', '\'', '\\', '/', '[', ']' };

            List<string> words = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> limerCaseWord = new List<string>();
            List<string> mixesCaseWord = new List<string>();
            List<string> upperCaseWord = new List<string>();

            foreach (var word in words)
            {
                int loweCase = 0;
                int upperCase = 0;

                foreach (var letter in word)
                {
                    if (char.IsLower(letter))
                    {
                        loweCase++;
                    }
                    else if (char.IsUpper(letter))
                    {
                        upperCase++;
                    }
                }
                if (loweCase == word.Length)
                {
                    limerCaseWord.Add(word);
                }
                else if (upperCase == word.Length)
                {
                    upperCaseWord.Add(word);
                }
                else
                {
                    mixesCaseWord.Add(word);
                }

            }
            Console.WriteLine("lower case {0}", string.Join(", ", limerCaseWord));
            Console.WriteLine("mixed case {0}", string.Join(", ", mixesCaseWord));
            Console.WriteLine("upper case {0}", string.Join(", ", upperCaseWord));
        }
    }
}