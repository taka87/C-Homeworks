using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Exercise
{
    class ComareTo
    {
        static void Main()
        {
            string alpha = "alpha";
            string score = "sCore";
            string scary = "scary";

            string word = "C#";
            string word1 = "c#";

            Console.WriteLine(score.CompareTo(scary));
            Console.WriteLine(scary.CompareTo(score));
            Console.WriteLine(scary.CompareTo(scary));

            Console.WriteLine(string.Compare(alpha, score, false));
            Console.WriteLine(string.Compare(score, scary, false));
            Console.WriteLine(string.Compare(score, scary, true));
            Console.WriteLine(string.Compare(score, score, StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine(word.Equals(word1));      //False  C# != c#
            Console.WriteLine(word.Equals(word1,StringComparison.CurrentCultureIgnoreCase)); //True
        }
    }
}
