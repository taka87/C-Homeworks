using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11OddOccurrences
{
    public class OddOccurrences
    {
        static void Main(string[] args)
        {
            List<string> word = Console.ReadLine().ToLower().Split().ToList();

            Dictionary<string, int> dic = GetRepeats(word);

            List<string> result = new List<string>();

            foreach (KeyValuePair<string, int> KVPair in dic)
            {
                if (KVPair.Value % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine("{0}, ", KVPair.Key);
            }
            //Console.WriteLine
        }

        public static Dictionary<string, int> GetRepeats(List<string> words)
        {
            Dictionary<string, int> wordRepeats = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordRepeats.ContainsKey(word))
                {
                    wordRepeats[word]++;
                }
                else
                {
                    wordRepeats.Add(word, 1);
                }
            }
            return wordRepeats;
        }
    }
}
