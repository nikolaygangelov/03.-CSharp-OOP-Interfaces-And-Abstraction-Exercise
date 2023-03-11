using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary, HashSet<IPrivate> privates) 
            : base(id, firstName, lastName, salary)
        {
            Privates = privates;//new HashSet<IPrivate>();
        }

        public HashSet<IPrivate> Privates { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");

            foreach (Private soldier in Privates)
            {
                sb.AppendLine($"  {soldier.ToString()}");
            }
            return sb.ToString().Trim();
        }
    }
}
