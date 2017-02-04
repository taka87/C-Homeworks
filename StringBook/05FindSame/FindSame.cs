using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05FindSame
{
    class FindSame
    {
        static void Main(string[] args)
        {
            string quote = "The main intent of the \"Intro C#\"" + " book is to introduce the C# programming to newbies.";

            string keyWord = "C#";
            int index = quote.IndexOf(keyWord);

            while (index != -1)
            {
                Console.WriteLine("{0} found at index {1}", keyWord, index);

                index = quote.IndexOf(keyWord, index + 1);
            }
        }
    }
}
