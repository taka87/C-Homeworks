using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07UpCase
{
    class UpCase
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string myRes = Regex.Replace(input, @"<upcase>(.*?)</upcase>",
                m => { var replaced = m.Groups[1].Value; return replaced.ToUpper(); });

            Console.WriteLine(myRes);
        }
    }
}
