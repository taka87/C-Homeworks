using System;

namespace _02RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            Random rnd = new Random();

            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = rnd.Next(words.Length);

                words[pos1] = words[pos2];
            }
            Console.WriteLine(string.Join("\r\n", words));
        }
    }
}