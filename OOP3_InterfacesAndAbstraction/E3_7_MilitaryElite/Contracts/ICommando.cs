using System;
using System.Collections.Generic;
using System.Text;
using E3_7_MilitaryElite.Models;

namespace E3_7_MilitaryElite.Contracts
{
    public interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyCollection<Mission> Missions { get; }
    }
}
