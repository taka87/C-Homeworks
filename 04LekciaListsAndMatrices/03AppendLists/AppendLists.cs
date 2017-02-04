using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
