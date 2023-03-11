using FoodShortage.Core.InterFaces;
using FoodShortage.Models;
using FoodShortage.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodShortage.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            List<IBuyer> buyers = new List<IBuyer>();
            int totalFood = 0;
            
            int numberOfPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = info[0];
                int age = int.Parse(info[1]);

                IBuyer ibuyer;
                if (info.Length == 4)
                {
                    string id = info[2];
                    string birthdate = info[3];
                    ibuyer = new Citizen(name, age, id, birthdate);
                    buyers.Add(ibuyer);
                }
                else if (info.Length == 3)
                {
                    string group = info[2];
                    ibuyer = new Rebel(name, age, group);
                    buyers.Add(ibuyer);
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                foreach (IBuyer buyer in buyers)
                {
                    if (buyer.Name == command)
                    {
                        buyer.BuyFood();
                    }
                }
            }

            foreach (IBuyer buyer in buyers)
            {
                totalFood += buyer.Food;
            }

            Console.WriteLine(totalFood);
        }
    }
}
