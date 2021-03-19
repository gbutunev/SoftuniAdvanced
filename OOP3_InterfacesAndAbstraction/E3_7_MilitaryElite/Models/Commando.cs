using System;
using System.Collections.Generic;
using System.Text;
using E3_7_MilitaryElite.Contracts;

namespace E3_7_MilitaryElite.Models
{
    class Commando : SpecialisedSoldier, ICommando
    {
        private List<Mission> missions;
        public Commando(string id, string fname, string lname, decimal salary, Corps corps)
            : base(id, fname, lname, salary, corps)
        {
            missions = new List<Mission>();
        }

        public IReadOnlyCollection<Mission> Missions { get { return missions.AsReadOnly(); } }

        public void AddMission(Mission mission)
        {
            missions.Add(mission);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");
            foreach (var item in Missions)
            {
                sb.AppendLine($"  {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
