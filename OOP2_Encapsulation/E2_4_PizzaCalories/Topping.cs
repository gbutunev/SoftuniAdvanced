using System;
using System.Collections.Generic;
using System.Text;

namespace E2_4_PizzaCalories
{
    public class Topping
    {
        private double typeModifier;
        private int weight;

        public double Calories { get { return 2 * typeModifier * weight; } }

        public Topping(string type, int weight)
        {
            typeModifier = type.ToLower() switch
            {
                "meat" => 1.2,
                "veggies" => 0.8,
                "cheese" => 1.1,
                "sauce" => 0.9,
                _ => throw new ArgumentException($"Cannot place {type} on top of your pizza."),
            };
            if (weight < 1 || weight > 50)
            {
                throw new ArgumentException($"{type} weight should be in the range [1..50].");
            }
            else
            {
                this.weight = weight;
            }
        }
    }
}
