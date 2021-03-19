using System;
using System.Collections.Generic;
using System.Text;

namespace E3_7_MilitaryElite.Contracts
{
    public interface ISpy : ISoldier
    {
        int CodeNumber { get; }
    }
}
