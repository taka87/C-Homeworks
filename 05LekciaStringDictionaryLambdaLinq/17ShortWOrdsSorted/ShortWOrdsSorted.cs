using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17ShortWOrdsSorted
{
    class ShortWOrdsSorted
    {
        static void Main(string[] args)
        {
            char[] separators = ".,:;()[]\"'\\/!? ".ToCharArray();

            string[] input = Console.ReadLine().ToLower().Split(separators);

            IEnumerable<string> result = input.Where(x => x != "").Where(x => x.Length < 5).OrderBy(c => c).Distinct();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
