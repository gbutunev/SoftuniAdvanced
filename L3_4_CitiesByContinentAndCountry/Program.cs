using System;
using System.Collections.Generic;

namespace L3_4_CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (!continents.ContainsKey(input[0]))
                {
                    continents.Add(input[0], new Dictionary<string, List<string>>());
                }
                if (!continents[input[0]].ContainsKey(input[1]))
                {
                    continents[input[0]].Add(input[1], new List<string>());
                }
                //if (!continents[input[0]][input[1]].Contains(input[2]))
                //{
                    continents[input[0]][input[1]].Add(input[2]);
                //}
            }

            foreach (var cont in continents)
            {
                Console.WriteLine($"{cont.Key}:");
                foreach (var country in cont.Value)
                {
                    Console.Write($"\t{country.Key} -> {String.Join(", ", country.Value)}");
                    Console.WriteLine();
                }
            }
        }
    }
}
