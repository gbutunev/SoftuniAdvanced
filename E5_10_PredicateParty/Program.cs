using System;
using System.Collections.Generic;
using System.Linq;

namespace E5_10_PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string cmd = Console.ReadLine();
            while (cmd != "Party!")
            {
                string[] parts = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (parts[0] == "Remove")
                {
                    people.RemoveAll(GetOperation(parts[1], parts[2]));
                }
                else if (parts[0] == "Double")
                {
                    for (int i = 0; i < people.Count; i++)
                    {
                        string person = people[i];
                        if (GetOperation(parts[1], parts[2]).Invoke(person))
                        {
                            people.Insert(i++, person);
                        }
                    }
                }
                cmd = Console.ReadLine();
            }

            if (people.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
        }

        static Predicate<string> GetOperation(string operation, string arg)
        {
            switch (operation)
            {
                case "StartsWith":
                    return x => x.StartsWith(arg);
                case "EndsWith":
                    return x => x.EndsWith(arg);
                case "Length":
                    return x => x.Length == int.Parse(arg);
                default:
                    return null;
            }
        }
    }
}
