using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10DictionaryExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> novDictionary = new Dictionary<string, string>()
            {
                { "novoPolveVDict", "5"}
            };

            novDictionary.Add("0", "-5");

            novDictionary["0"] = "05";

            Console.WriteLine("{0} -> {1}", novDictionary.Keys, novDictionary.Values);
        }
    }
}
