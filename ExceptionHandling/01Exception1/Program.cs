using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01Exception1
{
    class Program
    {
        static void Main()
        {
            string filename = "WrongTextFile.txt";
            ReadFile(filename);
        }

        static void ReadFile(string filename)
        {
            // Exceptions could be thrown in the code below
            try
            {
                TextReader reader = new StreamReader(filename);
                string line = reader.ReadLine();
                Console.WriteLine(line);
                reader.Close();
            }
            //catch (FileNotFoundException fnfe)
            //{
            //    // Exception handler for FileNotFoundException
            //    // We just inform the user that there is no such file
            //    Console.WriteLine("The file '{0}' is not found.", filename);
            //}
            catch (IOException ioe)
            {
                // Exception handler for other input/output exceptions
                // We just print the stack trace on the console
                Console.WriteLine(ioe.StackTrace);
            }
        }
    }
}