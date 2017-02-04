using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary <string, double> phoneBook = new Dictionary<string, double>();
            //var Dictionary = new Dictionary<string, int>();

            phoneBook["Pesho"] = 2;
            phoneBook["Minka"] = 5.5;
            phoneBook["Gosho"] = 5;
            phoneBook["Minkata"] = 3;

            foreach (var scores in phoneBook)
            {
                Console.WriteLine($"Name : {phoneBook.Key}");
            }
        }
    }
}
