using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _04PopulationAgregation
{
    class PopulationAgregation
    {
        static void Main(string[] args)
        {
            char[] delimeters =
                {
                '@', '#', '$', '&', '0',
                '1', '2', '3', '4', '5', '6', '7', '8', '9'
                };

            //List<string> input = Console.ReadLine().Split('\\').ToList();

            //List<string> output = new List<string>();

            //Console.WriteLine(output);
            SortedDictionary<string, int> country = new SortedDictionary<string, int>();
            SortedDictionary<string, long> town = new SortedDictionary<string, long>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "stop")
                {
                    break;
                }

                string[] commandArgs = command.Split('\\');

                for (int i = 0; i < 2; i++)
                {
                    commandArgs[i] = string.Join("", commandArgs[i].Split(delimeters, StringSplitOptions.RemoveEmptyEntries));
                }

                if (char.IsUpper(commandArgs[0][0]))
                {
                    string countryName = commandArgs[0];
                    string townName = commandArgs[1];
                    long population = long.Parse(commandArgs[2]);

                    if (country.ContainsKey(countryName))
                    {
                        country[countryName]++;
                    }
                    else
                    {
                        country.Add(countryName, 1);
                    }

                    if (town.ContainsKey(townName))
                    {
                        town[townName] = population;
                    }
                    else
                    {
                        town.Add(townName, population);
                    }
                }
                else
                {
                    string countryName = commandArgs[1];
                    string townName = commandArgs[0];
                    long population = long.Parse(commandArgs[2]);

                    if (country.ContainsKey(countryName))
                    {
                        country[countryName]++;
                    }
                    else
                    {
                        country.Add(countryName, 1);
                    }

                    if (town.ContainsKey(townName))
                    {
                        town[townName] = population;
                    }
                    else
                    {
                        town.Add(townName, population);
                    }
                }

                foreach (var countrys in country)
                {
                    Console.WriteLine(" {0} -> {1}", countrys.Key, countrys.Value);
                }

                foreach (var towns in town.OrderByDescending(kvp => kvp.Value).Take(3))
                {
                    Console.WriteLine(towns.Key + " -> " + towns.Value);
                }
                //string countryName = commandArgs
            }
        }
    }
}
