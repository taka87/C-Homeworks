using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ExtractSentencesByKeyword
{
    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine().ToLower();
            List<string> text = Console.ReadLine().Split('.', '!', '?').ToList();

            for (int sentence = 0; sentence < text.Count; sentence++)
            {
                string[] result = text[sentence].Split(new char[] { ',', ':', '(', ')', '[', ']', '\"', '\'', '/', '\\', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (result.Contains(input))
                {
                    Console.WriteLine(text[sentence].Trim());
                }
            }

            //char[] separator = { '.', '!', '?' };

            //string[] input = Console.ReadLine().Split(separator);

            //string[] output = new string[input.Length];

            //string sense = "to";

            //for (int i = 0; i < input.Length; i++)
            //{
            //    output = input.Contains(sense);
            //}
        }
    }
}
