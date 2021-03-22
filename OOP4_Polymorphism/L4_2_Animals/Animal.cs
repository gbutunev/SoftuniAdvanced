using System;
using System.Collections.Generic;
using System.Text;

namespace L4_2_Animals
{
    public class Animal
    {
        string name;
        string favouriteFood;

        public Animal(string name, string favouriteFood)
        {
            this.name = name;
            this.favouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {name} and my fovourite food is {favouriteFood}";
        }
    }
}
