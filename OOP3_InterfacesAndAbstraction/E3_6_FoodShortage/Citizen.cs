﻿using System;
using System.Collections.Generic;
using System.Text;

namespace E3_6_FoodShortage
{
    class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
        public string Birthday { get; private set; }
        public int Food { get; private set; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthday = birthdate;
        }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
