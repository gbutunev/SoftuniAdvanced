using System;
using System.Collections.Generic;
using System.Text;

namespace E3_7_MilitaryElite
{
    public interface ISoldier
    {
        string Id { get; }
        string FName { get; }
        string LName { get; }
    }
}
