using MilitaryElite.Enums;
using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialiseSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, Corps corps, HashSet<IRepair> repairs) 
            : base(id, firstName, lastName, salary, corps)
        {
            Repairs = repairs;
        }

        public HashSet<IRepair> Repairs { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Repairs:");

            foreach (Repair repair in Repairs)
            {
                sb.AppendLine($"  {repair.ToString()}");
            }
            return sb.ToString().Trim();
        }
    }
}
