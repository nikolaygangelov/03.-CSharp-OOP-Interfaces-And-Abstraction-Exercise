using MilitaryElite.Core.Interfaces;
using MilitaryElite.Enums;
using MilitaryElite.Models;
using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Engine : IEngine
    {
        private Dictionary<string, ISoldier> soldiers;

        public Engine()
        {
            soldiers = new Dictionary<string, ISoldier>();
        }
        public void Run()
        {
            ISoldier soldier = null;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                try
                {
                    string[] soldierInfo = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string id = soldierInfo[1];
                    string firstName = soldierInfo[2];
                    string lastName = soldierInfo[3];

                    if (soldierInfo[0] == "Private")
                    {
                        decimal salary = decimal.Parse(soldierInfo[4]);
                        soldier = GetPrivate(id, firstName, lastName, salary);
                    }
                    else if (soldierInfo[0] == "LieutenantGeneral")
                    {
                        soldier = GetLeutenantGeneral(id, firstName, lastName, soldierInfo);
                    }
                    else if (soldierInfo[0] == "Engineer")
                    {
                        soldier = GetEngineer(id, firstName, lastName, soldierInfo);
                    }
                    else if (soldierInfo[0] == "Commando")
                    {
                        soldier = GetCommando(id, firstName, lastName, soldierInfo);
                    }
                    else if (soldierInfo[0] == "Spy")
                    {
                        int codeNumber = int.Parse(soldierInfo[4]);
                        soldier = GetSpy(id, firstName, lastName, codeNumber);
                    }

                    soldiers.Add(id, soldier);

                    Console.WriteLine(soldier.ToString());
                }
                catch (Exception ex) { }
                
            }
        }

        

        private ISoldier GetPrivate(string id, string firstName, string lastName, decimal salary)//!!!!!!!!!!!!
            => new Private(id, firstName, lastName, salary);

        private ISoldier GetLeutenantGeneral(string id, string firstName, string lastName, string[] soldierInfo)
        {
            decimal salary = decimal.Parse(soldierInfo[4]);

            HashSet<IPrivate> privates = new HashSet<IPrivate>();

            if (soldierInfo.Length > 5)
            {
                for (int i = 5; i < soldierInfo.Length; i++)
                {
                    string privateId = soldierInfo[i];
                    IPrivate currentPrivate = (IPrivate)soldiers[privateId];
                    privates.Add(currentPrivate);
                }
            }
            return new LieutenantGeneral(id, firstName, lastName, salary, privates);
        }

        private ISoldier GetEngineer(string id, string firstName, string lastName, string[] soldierInfo)
        {
            decimal salary = decimal.Parse(soldierInfo[4]);

            bool isValidCorps = Enum.TryParse<Corps>(soldierInfo[5], out Corps corps);

            if (!isValidCorps)
            {
                throw new Exception();
            }

            HashSet<IRepair> repairs = new HashSet<IRepair>();

            for (int i = 6; i < soldierInfo.Length; i += 2)
            {
                string repairPart = soldierInfo[i];
                int repairHours = int.Parse(soldierInfo[i + 1]);

                IRepair repair = new Repair(repairPart, repairHours);

                repairs.Add(repair);
            }

            return new Engineer(id, firstName, lastName, salary, corps, repairs);
        }

        private ISoldier GetCommando(string id, string firstName, string lastName, string[] soldierInfo)
        {
            decimal salary = decimal.Parse(soldierInfo[4]);

            bool isValidCorps = Enum.TryParse<Corps>(soldierInfo[5], out Corps corps);

            if (!isValidCorps)
            {
                throw new Exception();
            }

            HashSet<IMission> missions = new HashSet<IMission>();

            for (int i = 6; i < soldierInfo.Length; i += 2)
            {
                string missionName = soldierInfo[i];
                string missionState = soldierInfo[i + 1];

                bool isValidMissionState = Enum.TryParse<State>(missionState, out State state);

                if (!isValidMissionState)
                {
                    continue;
                }

                IMission mission = new Mission(missionName, state);

                missions.Add(mission);
            }
            return new Commando(id, firstName, lastName, salary, corps, missions);
        }

        private ISoldier GetSpy(string id, string firstName, string lastName, int codeNumber)
        => new Spy(id, firstName, lastName, codeNumber);
    }
}
