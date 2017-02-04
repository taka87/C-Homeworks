using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ForbiddenSubstring
{
    class ForbiddenSubstring
    {
        static void Main(string[] args)
        {
            string output = Console.ReadLine();

            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {

                //zamenq vsqka chast ot texta na output s * kudeto nameri savpadenie ot znacite v inputa
                //na mqstoto na zvexdishka moje da ima vsqkakva promenliva
                output = output.Replace(input[i], new string('*', input[i].Length));
            }

            //str.Trim premahva novi redove whitespace i t.n.

            Console.WriteLine(output);
        }
    }
}
