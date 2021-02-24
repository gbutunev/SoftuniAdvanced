using System;
using System.Collections.Generic;
using System.Linq;

namespace E5_11_PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, Predicate<string>> predicates = new Dictionary<string, Predicate<string>>();

            string cmd = Console.ReadLine();
            while (cmd != "Print")
            {
                string[] parts = cmd.Split(";", StringSplitOptions.RemoveEmptyEntries);

                if (parts[0] == "Add filter")
                {
                    Predicate<string> predicate = null;
                    switch (parts[1])
                    {
                        case "Starts with":
                            predicate = x => x.StartsWith(parts[2]);
                            break;
                        case "Ends with":
                            predicate = x => x.EndsWith(parts[2]);
                            break;
                        case "Length":
                            predicate = x => x.Length == int.Parse(parts[2]);
                            break;
                        case "Contains":
                            predicate = x => x.Contains(parts[2]);
                            break;
                    }

                    predicates.Add($"{parts[1]} {parts[2]}", predicate);
                }
                else if (parts[0] == "Remove filter")
                {
                    predicates.Remove($"{parts[1]} {parts[2]}");
                }

                cmd = Console.ReadLine();
            }

            foreach(var predicate in predicates.Values)
            {
                people.RemoveAll(predicate);
            }

            Console.WriteLine(string.Join(" ", people));
        }
    }
}
