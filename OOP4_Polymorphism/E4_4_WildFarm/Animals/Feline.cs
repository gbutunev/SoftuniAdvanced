using System;
using System.Collections.Generic;
using System.Text;

namespace E4_4_WildFarm.Animals
{
    public abstract class Feline : Mammal
    {
        public string Breed { get; private set; }
        protected Feline(string name, double weight, string livingRegion, string breed, HashSet<string> foodSet, double foodModifier)
            : base(name, weight, livingRegion, foodSet, foodModifier)
        {
            Breed = breed;
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
