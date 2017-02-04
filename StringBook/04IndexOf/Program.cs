using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = "   C# Programming Course";

            int index = book.IndexOf("C#");

            Console.WriteLine(index);

            // index = 16

            int indexOf = book.LastIndexOf("C#");
            Console.WriteLine(indexOf);

            indexOf = book.IndexOf("Course");
            Console.WriteLine(indexOf);

            indexOf = book.IndexOf("COURSE");
            Console.WriteLine(indexOf);

            indexOf = book.IndexOf("ram");
            Console.WriteLine(indexOf);

            indexOf = book.IndexOf("r");
            Console.WriteLine(indexOf);

            indexOf = book.IndexOf("r", 10);
            Console.WriteLine(indexOf);

            indexOf = book.IndexOf("r", 5);
            Console.WriteLine(indexOf);

            indexOf = book.ToLower().IndexOf("intro");
            Console.WriteLine(indexOf);

        }
    }
}
