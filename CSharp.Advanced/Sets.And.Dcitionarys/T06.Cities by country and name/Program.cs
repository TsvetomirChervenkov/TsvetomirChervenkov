using System;
using System.Collections.Generic;

namespace T06.Cities_by_country_and_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> map = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int row = 0; row < inputLines; row++)
            {
                string[] data = Console.ReadLine().Split();
                string continent = data[0];
                string country = data[1];
                string town = data[2];

                AddTown(continent, country, town , map);
            }

            PrntMap(map);
        }

        private static void PrntMap(Dictionary<string, Dictionary<string, List<string>>> map)
        {        
            foreach (var kvp in map)
            {
                Console.WriteLine($"{kvp.Key}:");
                foreach (var kvp2 in kvp.Value)
                {
                    Console.WriteLine($"{kvp2.Key} -> {string.Join(", ", kvp2.Value)}");
                }
            }
        }

        private static void AddTown(string continent, string country, string town, Dictionary<string, Dictionary<string, List<string>>> map)
        {
            if (!map.ContainsKey(continent))
            {           
                map.Add(continent, new Dictionary<string, List<string>>());            
            }
            if (!map[continent].ContainsKey(country))
            {
                map[continent].Add(country, new List<string>());
            }
            map[continent][country].Add(town);        
        }
    }
}
