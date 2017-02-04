using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15OddOccurences
{
    class OddOccurences
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in input)
            {
                //cikala prisvoqva v dictionary-to kolko pati se povtarq dadena dumichka v inputa
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }

            List<string> result = new List<string>();

            foreach (var pair in counts)
            {                
                if (pair.Value % 2 == 1)
                {
                    result.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ",result));
        }
    }
}
