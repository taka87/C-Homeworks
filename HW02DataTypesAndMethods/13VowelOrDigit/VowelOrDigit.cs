using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            //char symbol = '\u0000';

            char symbol = char.Parse(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') || (symbol == 'o') || (symbol == 'u'))
            {
                Console.WriteLine("vowel");
            }
            else if ((symbol >= '0') && (symbol <= '9'))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.Write("other");
            }
        }
    }
}
