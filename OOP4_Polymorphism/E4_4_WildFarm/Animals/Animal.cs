using E4_4_WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace E4_4_WildFarm.Animals
{
    public abstract class Animal
    {
        private HashSet<string> foodSet;
        private double foodModifier;
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }


        protected Animal(string name, double weight, HashSet<string> foodSet, double foodModifier)
        {
            Name = name;
            Weight = weight;
            this.foodSet = foodSet;
            this.foodModifier = foodModifier;
        }

        public virtual void Eat(Food food)
        {
            MakeSound();
            if (foodSet.Contains(food.GetType().Name))
            {
                Weight += food.Quantity * foodModifier;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public abstract void MakeSound();
    }
}
