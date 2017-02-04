using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ExerciseStringIndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Welcome to SoftUni!";

            int offcet = 0;

            Console.WriteLine(input.IndexOf("o", 5));

            for (int i = 0; i < input.Length; i++)
            {
                offcet = input.IndexOf("o", offcet + 1);

                if (offcet==-1)
                {
                    break;
                }
                Console.WriteLine("found 'o' at index offcet {0}", offcet);
            }

            Console.WriteLine(input.LastIndexOf("o"));
        }
    }
}
