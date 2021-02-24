using System;
using System.Collections.Generic;

namespace E8_5_ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string cmd = Console.ReadLine();
            while(cmd != "END")
            {
                string[] parts = cmd.Split(" ");

                people.Add(new Person(parts[0], int.Parse(parts[1]), parts[2]));
                cmd = Console.ReadLine();
            }

            int personIndex = int.Parse(Console.ReadLine()) - 1;
            Person selectedPerson = people[personIndex];

            int count = 0;
            foreach (var person in people)
            {
                if (selectedPerson.CompareTo(person) == 0)
                {
                    count++;
                }
            }

            if (count == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{count} {people.Count - count} {people.Count}");
            }
        }
    }
}
