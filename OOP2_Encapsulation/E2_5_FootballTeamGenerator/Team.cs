using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E2_5_FootballTeamGenerator
{
    class Team
    {
        private string name;
        private Dictionary<string, Player> players;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public Team(string name)
        {
            Name = name;
            players = new Dictionary<string, Player>();
        }

        public void RemovePlayer(string name)
        {
            if (players.ContainsKey(name))
            {
                players.Remove(name);
            }
            else
            {
                Console.WriteLine($"Player {name} is not in {Name} team.");
            }
        }

        public void AddPlayer(Player player)
        {
            players.Add(player.Name, player);
        }

        public override string ToString()
        {
            return $"{Name} - {(players.Count == 0 ? 0 : Math.Round(players.Values.Average(x => x.Rating)))}";
        }
    }
}
