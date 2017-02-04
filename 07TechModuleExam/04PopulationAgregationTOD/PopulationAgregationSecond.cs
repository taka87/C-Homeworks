using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04PopulationAgregationTOD
{
    class PopulationAgregationSecond
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> CountryD = new SortedDictionary<string, int>();
            SortedDictionary<string, long> TownsD = new SortedDictionary<string, long>();

            char[] delimeters =
                {
                '@', '#', '$', '&', '0',
                '1', '2', '3', '4', '5', '6', '7', '8', '9'
                };

            string Country = "";
            string Towns = "";
            long Population = 0;

            while (true)
            {
                string Input = Console.ReadLine();
                if (Input == "stop")
                {
                    break;
                }
                string[] InputElements = Input.Split('\\');

                for (int i = 0; i < 2; i++)
                {
                    InputElements[i] = string.Join("", InputElements[i].Split(delimeters, StringSplitOptions.RemoveEmptyEntries));
                }
                if (char.IsUpper(InputElements[0][0]))
                {
                    Country = InputElements[0];
                    Towns = InputElements[1];
                    Population = long.Parse(InputElements[2]);
                }
                else
                {
                    Country = InputElements[1];
                    Towns = InputElements[0];
                    Population = long.Parse(InputElements[2]);
                }

                if (CountryD.ContainsKey(Country))
                {
                    CountryD[Country]++;
                }
                else
                {
                    CountryD.Add(Country, 1);
                }
                if (TownsD.ContainsKey(Towns))
                {
                    TownsD[Towns] = Population;
                }
                else
                {
                    TownsD.Add(Towns, Population);
                }
            }

            foreach (var C in CountryD)
            {
                Console.WriteLine("{0} -> {1}", C.Key, C.Value);
            }

            foreach (var C in TownsD.OrderByDescending(k => k.Value).Take(3))
            {
                Console.WriteLine("{0} -> {1}", C.Key, C.Value);
            }
        }
    }
}
