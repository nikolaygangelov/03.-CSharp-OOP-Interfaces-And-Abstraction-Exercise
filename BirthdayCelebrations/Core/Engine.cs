using System;
using System.Collections.Generic;
using System.Text;
using BirthdayCelebrations.Core.Interfaces;

namespace BirthdayCelebrations.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            List<IBirthable> birthables = new List<IBirthable>();
            IBirthable birthable;

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] info = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (info[0] == "Citizen")
                {
                    string citizenName = info[1];
                    int citizenAge = int.Parse(info[2]);
                    string citizenId = info[3];
                    string birthdate = info[4];

                    birthable = new Citizen(citizenName, citizenAge, citizenId, birthdate);
                    birthables.Add(birthable);
                    birthable.AddBirthdate();
                }
                else if (info[0] == "Pet")
                {
                    string petName = info[1];
                    string birthdate = info[2];

                    birthable = new Pet(petName, birthdate);
                    birthables.Add(birthable);
                    birthable.AddBirthdate();
                }
            }

            string specificYear = Console.ReadLine();

            foreach (IBirthable ibirthable in birthables)
            {
                foreach (string birthdate in ibirthable.Birthdates.FindAll(b => b
                .EndsWith(specificYear)))
                {
                    Console.WriteLine(birthdate);
                }
            }
        }
    }
}
