using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Concat
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello ";
            string reder = "world!";
            string result = greeting + reder;

            Console.WriteLine(result);
            Console.WriteLine(greeting + reder);
            
            result += " How Are YOU ?";
            Console.WriteLine(result);
        }
    }
}
