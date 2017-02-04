﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitStringin20Chars
{
    class FitStringin20Chars
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length < 20)
            {
                Console.WriteLine("{0}", input.PadRight(20, '*'));
            }
            else
            {
                Console.WriteLine(input.Substring(0, 20));
            }
        }
    }
}
