using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Repair : IRepair
    {
        public Repair(string partName, int workedHours)
        {
            PartName = partName;
            WorkedHours = workedHours;
        }

        public string PartName { get; private set; }

        public int WorkedHours { get; private set; }

        public override string ToString()
        {
            return $"Part Name: {PartName} Hours Worked: {WorkedHours}";
        }
    }
}
