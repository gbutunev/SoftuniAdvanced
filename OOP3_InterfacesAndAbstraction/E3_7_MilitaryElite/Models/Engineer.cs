using System;
using System.Collections.Generic;
using System.Text;
using E3_7_MilitaryElite.Contracts;

namespace E3_7_MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<Repair> repairs;
        public IReadOnlyCollection<Repair> Repairs { get { return repairs.AsReadOnly(); } }

        public Engineer(string id, string fname, string lname, decimal salary, Corps corps)
            : base(id, fname, lname, salary, corps)
        {
            repairs = new List<Repair>();
        }

        public void AddRepair(Repair repair)
        {
            repairs.Add(repair);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Repairs:");
            foreach (var item in Repairs)
            {
                sb.AppendLine($"  {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
