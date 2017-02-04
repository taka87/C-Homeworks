using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07OccurencesInString
{
    class OccurencesInString
    {
        static void Main(string[] args)
        {
            string mainString = Console.ReadLine().ToLower();
            string subString = Console.ReadLine().ToLower();

            int index = -1;
            bool has = false;
            int counter = 0;

            while (!has)
            {
                index = mainString.IndexOf(subString, index + 1);

                if (index != -1)
                {
                    counter++;

                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
