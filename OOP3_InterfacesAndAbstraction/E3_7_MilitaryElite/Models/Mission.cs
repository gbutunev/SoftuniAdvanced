using System;
using System.Collections.Generic;
using System.Text;

namespace E3_7_MilitaryElite.Models
{
    public class Mission
    {
        public string CodeName { get; private set; }
        public State State { get; private set; }

        public Mission(string codeName, State state)
        {
            CodeName = codeName;
            State = state;
        }

        public void CompleteMission()
        {
            State = State.Finished;
        }

        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {State}";
        }
    }
}
