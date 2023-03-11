using MilitaryElite.Enums;
using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Commando : SpecialiseSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, decimal salary, Corps corps, HashSet<IMission> missions) 
            : base(id, firstName, lastName, salary, corps)
        {
            Missions = missions;//new HashSet<Mission>();
        }

        public HashSet<IMission> Missions { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");

            foreach (Mission mission in Missions)
            {
                sb.AppendLine($"  {mission.ToString()}");
            }
            return sb.ToString().Trim();
        }
    }
}
