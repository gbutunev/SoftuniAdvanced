using System;
using System.Collections.Generic;
using System.Linq;

namespace E3_8_Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> participants = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();
            while (input != "end of contests")
            {
                string[] contest = input.Split(":");

                if (!contests.ContainsKey(contest[0]))
                {
                    contests.Add(contest[0], contest[1]);
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "end of submissions")
            {
                string[] parts = input.Split("=>");
                string contest = parts[0];
                string pass = parts[1];
                string user = parts[2];
                int points = int.Parse(parts[3]);

                if (contests.ContainsKey(contest))
                {
                    if (contests[contest] == pass)
                    {
                        if (!participants.ContainsKey(user))
                        {
                            participants.Add(user, new Dictionary<string, int>());
                        }
                        if (participants[user].ContainsKey(contest))
                        {
                            if (participants[user][contest] < points)
                            {
                                participants[user][contest] = points;
                            }
                        }
                        else
                        {
                            participants[user].Add(contest, points);
                        }
                    }
                }
                input = Console.ReadLine();
            }

            var topCandidate = participants.OrderByDescending(x => x.Value.Values.Sum()).First();

            Console.WriteLine($"Best candidate is {topCandidate.Key} with total {topCandidate.Value.Values.Sum()} points.");
            Console.WriteLine("Ranking:");
            participants
                .OrderBy(x => x.Key)
                .ToList()
                .ForEach(x =>
                {
                    Console.WriteLine(x.Key);
                    x.Value
                    .OrderByDescending(c => c.Value)
                    .ToList()
                    .ForEach(c =>
                    {
                        Console.WriteLine($"#  {c.Key} -> {c.Value}");
                    });
                });

        }
    }
}
