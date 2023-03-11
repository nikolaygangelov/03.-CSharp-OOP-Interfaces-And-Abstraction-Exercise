using FoodShortage.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdates = new List<string>();
            Birthdate = birthdate;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public List<string> Birthdates { get; set; }
        public string Birthdate { get; set; }

        public int Food { get; set; }

        public void AddBirthdate()
        {
            Birthdates.Add(Birthdate);
        }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
