using System;
using System.Collections.Generic;
using System.Text;

namespace E4_4_WildFarm.Animals
{
    public abstract class Bird : Animal
    {
        public double WingSize { get; private set; }

        protected Bird(string name, double weight, double wingSize, HashSet<string> foodSet, double foodModifier) : base(name, weight, foodSet, foodModifier)
        {
            WingSize = wingSize;
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
