using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "welcom softuni!";

            Console.WriteLine(input[input.Length - 1]);

            char[] sentence = input.ToCharArray();
            sentence[sentence.Length - 1] = '.';

            Console.WriteLine(sentence);
            Console.WriteLine(string.Join("", sentence));
        }
    }
}
