using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08DictionaryTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> team = new Dictionary<string, double>();
            //var Dictionary = new Dictionary<string, int>();

           team["Aresenal"] = 0;
            team["Barsa"] =0;
           team["Lester"] = 0;
            team["Minkata"] =0;

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                string team = input[0];

            }
        }
    }
}
