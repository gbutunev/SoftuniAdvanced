using System;
using System.Collections.Generic;

namespace E2_5_FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] cmd = input.Split(";", StringSplitOptions.RemoveEmptyEntries);

                switch (cmd[0])
                {
                    case "Team":
                        teams.Add(cmd[1], new Team(cmd[1]));
                        break;
                    case "Add":
                        if (teams.ContainsKey(cmd[1]))
                        {
                            try
                            {
                                Player player = new Player(cmd[2], int.Parse(cmd[3]), int.Parse(cmd[4]), int.Parse(cmd[5]), int.Parse(cmd[6]), int.Parse(cmd[7]));
                                teams[cmd[1]].AddPlayer(player);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Team {cmd[1]} does not exist.");
                        }
                        break;
                    case "Remove":
                        try
                        {
                            teams[cmd[1]].RemovePlayer(cmd[2]);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "Rating":
                        if (teams.ContainsKey(cmd[1]))
                        {
                            Console.WriteLine(teams[cmd[1]]);
                        }
                        else
                        {
                            Console.WriteLine($"Team {cmd[1]} does not exist.");
                        }
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
