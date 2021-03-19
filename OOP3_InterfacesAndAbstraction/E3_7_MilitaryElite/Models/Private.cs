using System;
using System.Collections.Generic;
using System.Text;

namespace E3_7_MilitaryElite.Models
{
    public class Private : IPrivate
    {
        public decimal Salary { get; private set; }
        public string Id { get; private set; }
        public string FName { get; private set; }
        public string LName { get; private set; }

        public Private(string id, string fname, string lname, decimal salary)
        {
            Id = id;
            FName = fname;
            LName = lname;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {FName} {LName} Id: {Id} Salary: {Salary:F2}";
        }
    }
}
