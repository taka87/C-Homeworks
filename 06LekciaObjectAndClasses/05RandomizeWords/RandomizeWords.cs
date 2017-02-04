using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            int count = input.Count;
            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                int index = rnd.Next(0, input.Count);
                Console.WriteLine(input[index]);
                input.RemoveAt(index);
            }
        }
    }
}
