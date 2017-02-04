using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09CompareString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "pernik sofiq";
            string other = "parij";
            Console.WriteLine(input.CompareTo(other));
            Console.WriteLine(input.Insert(6, " ok "));
            // sravnqva po azbuchen red p e predi parij
        }
    }
}
