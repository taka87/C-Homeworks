using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            char[] separator = { ' ', '=', '(', '/', '\\', ')', '&', '/', '[', ']', ',', '!', '?', ':', '.' };


            List<string> input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> res = new List<string>();

            foreach (string word in input)
            {
                char[] medi = new char[word.Length];
                bool pali = true;
                for (int i = 0; i < word.Length; i++)
                {
                    medi[i] = word[i];
                }

                for (int i = 0; i < word.Length; i++)
                {
                    if (medi[word.Length - 1 - i] != medi[i])
                    {
                        pali = false;
                    }
                }
                if (pali)
                {
                    if (res.Contains(word))
                    {
                        continue;
                    }
                    else
                    {
                        res.Add(word);
                    }
                }
            }

            res.Sort();
            Console.WriteLine(string.Join(", ", res));
        }
    }
}
