using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models.Interfaces
{
    public interface ISpecialiseSoldier : IPrivate
    {
       Corps Corps { get; }
    }
}
