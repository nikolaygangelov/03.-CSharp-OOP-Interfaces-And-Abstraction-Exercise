﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_IPerson
{
    public class Citizen : IPerson
    {
        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public string Name { get; private set; }
        public int Age { get; private set; }

    }
}
