using System;
using System.Collections.Generic;
using System.Text;

namespace E3_7_MilitaryElite
{
    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }
    }
}
