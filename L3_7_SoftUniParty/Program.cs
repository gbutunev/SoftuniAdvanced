using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace L3_7_SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> allGuests = new HashSet<string>();
            HashSet<string> attendingGuests = new HashSet<string>();

            string input = Console.ReadLine();
            while (input != "PARTY")
            {
                allGuests.Add(input);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while(input != "END")
            {
                attendingGuests.Add(input);
                input = Console.ReadLine();
            }

            allGuests.ExceptWith(attendingGuests);
            Console.WriteLine(allGuests.Count);

            Regex pattern = new Regex($"^[0-9]");

            foreach (var guest in allGuests.ToList())
            {
                if (pattern.IsMatch(guest))
                {
                    Console.WriteLine(guest);
                    allGuests.Remove(guest);
                }
            }
            foreach (var guest in allGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
