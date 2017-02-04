using System;
using System.IO;

namespace _10RemoveSymbolsString
{
    class Program
    {
        static void Main(string[] args)
        {

            //not working
            string fileData = "    \n\n ivan Ivanov             Ivan";

            string reduced = fileData.Trim();

            Console.WriteLine(reduced);

            string fileString = " 111$ %    Ivan Ivanov ### s        Ur  ";
            // new line
            char[] trimChar = new char[] { ' ', '1', '$', '#', 's' };

            string reducedString = fileString.Trim(trimChar);

            Console.WriteLine(reducedString);
        }
    }
}
