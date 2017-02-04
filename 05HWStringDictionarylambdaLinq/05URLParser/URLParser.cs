using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05URLParser
{
    class URLParser
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ', '/', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (input[0].Contains("http") || input[0].Contains("https") || input[0].Contains("ftp"))
            {
                Console.WriteLine("[protocol] = \"{0}\"", input[0]);
            }
            else
            {
                input.Insert(0, "\"\"");
                Console.WriteLine($"[protocol] = {input[0]}");
            }

            Console.WriteLine("[server] = \"{0}\"", input[1]);

            if (input.Count > 2)
            {
                if (input.Count > 3)
                {
                    Console.Write("[resource] = ");
                    for (int i = 2; i < input.Count; i++)
                    {
                        if (i == 2)
                        {
                            Console.Write("\"" + input[i]);
                        }
                        else if (i == input.Count - 1)
                        {
                            Console.Write("/" + input[i] + "\"");
                        }
                        else
                        {
                            Console.Write("/" + input[i]);
                        }

                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("[resource] = \"{0}\"", input[2]);
                }
            }
            else
            {
                Console.WriteLine("[resource] = \"\"");
            }
        }
    }
}
