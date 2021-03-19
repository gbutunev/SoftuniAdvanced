using System;
using System.Collections.Generic;
using System.Text;

namespace E3_7_MilitaryElite
{
    public interface IPrivate : ISoldier
    {
        decimal Salary { get; }
    }
}
