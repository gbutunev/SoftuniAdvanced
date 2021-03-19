using System;
using System.Collections.Generic;
using System.Text;

namespace E3_6_FoodShortage
{
    class Rebel : IBuyer
    {
        public int Age { get; private set; }
        public string Group { get; private set; }
        public int Food { get; private set; }

        public Rebel(int age, string group)
        {
            Age = age;
            Group = group;
        }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
