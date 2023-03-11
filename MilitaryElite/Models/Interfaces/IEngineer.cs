using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models.Interfaces
{
    public interface IEngineer : ISpecialiseSoldier
    {
        HashSet<IRepair> Repairs { get; }
    }
}
