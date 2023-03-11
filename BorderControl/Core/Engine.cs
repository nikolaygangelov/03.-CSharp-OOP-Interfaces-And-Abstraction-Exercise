using BorderControl.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            List<IIdentifiable> identities = new List<IIdentifiable>();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] info = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                IIdentifiable identifiable;
                if (info.Length == 3)
                {
                    string citizneName = info[0];
                    int citizenAge = int.Parse(info[1]);
                    string citizenId = info[2];
                    identifiable = new Citizen(citizneName, citizenAge, citizenId);

                    identities.Add(identifiable);
                }
                else if (info.Length == 2)
                {
                    string robotModel = info[0];
                    string robotId = info[1];
                    identifiable = new Robot(robotModel, robotId);

                    identities.Add(identifiable);
                }
            }

            string fakeId = Console.ReadLine();

            foreach (IIdentifiable citizen in identities.FindAll(c => c.Id
            .EndsWith(fakeId)))
            {
                Console.WriteLine(citizen.Id);
            }
        }
    }
}
