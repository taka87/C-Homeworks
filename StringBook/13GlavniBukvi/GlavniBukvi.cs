using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13GlavniBukvi
{
    class GlavniBukvi
    {
        static void Main(string[] args)
        {
            string str = "NqkKuv Si TEXT";

            Console.WriteLine(ExtractCapitals(str));
        }
        static string ExtractCapitals(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if (char.IsUpper(ch))
                {
                    result.Append(ch);
                }
            }

            return result.ToString();
        }
    }
}
