using System;
using System.Collections.Generic;
using System.Text;

namespace E3_7_MilitaryElite
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
