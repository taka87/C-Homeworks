﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04VariableInHex
{
    class VariableInHex
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();

            int num = Convert.ToInt32(hex, 16);

            Console.WriteLine(num);
        }
    }
}
