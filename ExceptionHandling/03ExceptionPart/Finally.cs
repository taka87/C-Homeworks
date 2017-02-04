using System;
using System.IO;

namespace _03ExceptionPart
{
    class Finally
    {
        static void Main(string[] args)
        {
            try
            {
                string fileName = "WrongFileName.txt";
                ReadFile(fileName);
            }
            catch (Exception e)
            {

                throw new ApplicationException("Bad thing happended", e);
            }
        }

        private static void ReadFile(string fileName)
        {
            //try
            //{
            //    TextReader reader = new StreamReader(fileName);
            //    string line = reader.ReadLine();
            //    Console.WriteLine(line);
            //    reader.Close();
            //}
            //catch (FileNotFoundException fnfe)
            //{
            //    Console.WriteLine("File {0} does not exist", fileName);
            //}

            TextReader reader = null;
            try
            {
               // reader = new StreamReader(fileName);
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
            finally
            {
                // Always close "reader" (first check if properly opened)

                //if (reader != null)
                //{
                    reader.Close();
                //}
            }
        }
    }
}
