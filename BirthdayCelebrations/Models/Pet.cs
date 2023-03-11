using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Pet : IBirthable
    {
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
            Birthdates = new List<string>();
        }

        public string Name { get; set; }

        public string Birthdate { get; set; }

        public List<string> Birthdates { get; set; }

        public void AddBirthdate()
        {
            Birthdates.Add(Birthdate);
        }
    }
}
