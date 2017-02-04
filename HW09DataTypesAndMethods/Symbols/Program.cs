using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbols
{
    class Program
    {
        static void Main(string[] args)
        {

            char symbol = 'a';              // An ordinary character
            char symbol1 = '\u006F';         // Unicode character code in a
                                            // hexadecimal format (letter 'o')
            char symbol2 = '\u8449';         // 葉 (Leaf in Traditional Chinese)
            char symbol3 = '\'';                // Assigning the single quote character
            char symbol4 = '\\';            // Assigning the backslash character
            char symbol5 = '\n';            // Assigning new line character
            char symbol6 = '\t';            // Assigning TAB character
            char symbol7 = 'a';

            Console.WriteLine(symbol);
            Console.WriteLine(symbol1);
            Console.WriteLine(symbol2);
            Console.WriteLine(symbol3);
            Console.WriteLine(symbol4);
            Console.WriteLine(symbol5);
            Console.WriteLine(symbol6);
            Console.WriteLine(symbol7);

            string firstName = "Ivan";
            string lastName = "Ivanov";
            Console.WriteLine(@"Hello, ""{0}"" !", firstName);
            string fullName = $"{firstName} {lastName}";
            Console.WriteLine("Your full name is {0}.", fullName);

        }
    }
}
