using System;
using System.Collections.Generic;
using System.Text;

namespace E3_7_MilitaryElite.Models
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public Corps Corps { get; private set; }
        protected SpecialisedSoldier(string id, string fname, string lname, decimal salary, Corps corps)
            : base(id, fname, lname, salary)
        {
            Corps = corps;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Corps: {Corps}";
        }
    }
}
