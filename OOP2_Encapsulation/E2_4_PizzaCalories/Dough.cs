using System;
using System.Collections.Generic;
using System.Text;

namespace E2_4_PizzaCalories
{
    public class Dough
    {
        private double flourModifier;
        private double bakingModifier;
        private int weight;

        public double Calories
        {
            get { return 2 * weight * flourModifier * bakingModifier; }
        }

        public Dough(string flour, string type, int weight)
        {
            flourModifier = flour.ToLower() switch
            {
                "white" => 1.5,
                "wholegrain" => 1.0,
                _ => throw new ArgumentException("Invalid type of dough."),
            };

            bakingModifier = type.ToLower() switch
            {
                "crispy" => 0.9,
                "chewy" => 1.1,
                "homemade" => 1.0,
                _ => throw new ArgumentException("Invalid type of dough."),
            };

            if (weight <1 || weight > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            else
            {
                this.weight = weight;
            }
        }
    }

}
