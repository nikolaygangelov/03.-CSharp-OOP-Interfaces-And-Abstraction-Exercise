using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models.Interfaces
{
    public interface ICommando : ISpecialiseSoldier
    {
        HashSet<IMission> Missions { get; }
    }
}
