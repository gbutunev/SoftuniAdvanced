using System;
using System.Collections.Generic;
using System.Text;

namespace E3_7_MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<IPrivate> privates;
        public IReadOnlyCollection<IPrivate> Privates { get { return privates.AsReadOnly(); } }
        public LieutenantGeneral(string id, string fname, string lname, decimal salary)
            : base(id, fname, lname, salary)
        {
            privates = new List<IPrivate>();
        }

        public void AddPrivate(IPrivate @private)
        {
            privates.Add(@private);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            foreach (var item in privates)
            {
                sb.AppendLine($"  {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
