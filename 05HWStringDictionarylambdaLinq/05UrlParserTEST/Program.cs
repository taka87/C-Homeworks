using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _05UrlParserTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Uri MyUrl = new Uri(input);

            string first = MyUrl.Scheme;
            string hostPart = MyUrl.Authority;
            string pathPart = MyUrl.PathAndQuery;

            if (first == "")
            {
                Console.WriteLine($"[resource] = \"\"");
            }
            else
            {
                Console.WriteLine($"[protocol] = \"{first}\"");
            }

            Console.WriteLine($"[server] = \"{hostPart}\"");

            if (pathPart == "")
            {
                Console.WriteLine($"[resource] = \"\"");
            }
            else
            {
                pathPart = pathPart.Remove(0, 1);
                Console.WriteLine($"[resource] = \"{pathPart}\"");
            }
        }
    }
}
