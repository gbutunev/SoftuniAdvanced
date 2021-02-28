using System;
using System.Collections.Generic;

namespace L2_4_Team
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                List<Person> people = new List<Person>();
                for (int i = 0; i < n; i++)
                {
                    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    Person p = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));

                    people.Add(p);
                }

                Team team = new Team("team");
                people.ForEach(p => team.AddPlayer(p));
                Console.WriteLine($"First team: {team.FirstTeam.Count}");
                Console.WriteLine($"Reserve team: {team.ReserveTeam.Count}");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
