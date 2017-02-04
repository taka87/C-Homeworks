using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LowerUpper
{
    class LoweUpper
    {
        static void Main(string[] args)
        {
            string pass1 = "PasswoRD";
            string pass2 = "PAssWoRd";
            string pass3 = "password";

            Console.WriteLine(pass1.ToLower() == "password");
            Console.WriteLine(pass2.ToLower() == "password");
            Console.WriteLine(pass3.ToUpper() == "PASSWORD");
        }
    }
}
