using System;
using System.Collections.Generic;
using System.Text;

namespace E4_4_WildFarm.Animals
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; private set; }
        protected Mammal(string name, double weight, string livingRegion, HashSet<string> foodSet, double foodModifier)
            : base(name, weight, foodSet, foodModifier)
        {
            LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
