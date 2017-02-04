using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06CopyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("napishi cifra");
            int n = int.Parse(Console.ReadLine());

            // char[] ch = new char[] { 'a', 'b', 'c', 'd', 'f', 'h' };
            string neshtsi = null;

            Console.WriteLine("napishi neshto");
            neshtsi = Console.ReadLine();

            Console.WriteLine(neshtsi);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.Write((char)('a' + i));
                        Console.Write((char)('a' + j));
                        Console.WriteLine((char)('a' + k));

                    }
                    //Console.WriteLine();
                }
            }
        }
    }
}
