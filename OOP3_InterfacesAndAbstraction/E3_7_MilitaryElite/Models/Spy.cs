using System;
using System.Collections.Generic;
using System.Text;
using E3_7_MilitaryElite.Contracts;

namespace E3_7_MilitaryElite.Models
{
    public class Spy : ISpy
    {
        public int CodeNumber { get; private set; }
        public string Id { get; private set; }
        public string FName { get; private set; }
        public string LName { get; private set; }

        public Spy(string id, string fname, string lname, int codeNumber)
        {
            Id = id;
            FName = fname;
            LName = lname;
            CodeNumber = codeNumber;
        }

        public override string ToString()
        {
            return $"Name: {FName} {LName} Id: {Id}{Environment.NewLine}Code Number: {CodeNumber}";
        }
    }
}
