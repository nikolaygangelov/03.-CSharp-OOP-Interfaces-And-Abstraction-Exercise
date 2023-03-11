using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Enums;
using MilitaryElite.Models.Interfaces;

namespace MilitaryElite.Models
{
    public abstract class SpecialiseSoldier : Private, ISpecialiseSoldier
    {
        protected SpecialiseSoldier(string id, string firstName, string lastName, decimal salary, Corps corps) 
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public Corps Corps { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{Environment.NewLine}Corps: {Corps}";
        }

    }
}
