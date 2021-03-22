using System;
using System.Collections.Generic;
using System.Text;

namespace E4_4_WildFarm.Animals
{
    public class Hen : Bird
    {
        private static HashSet<string> foods = new HashSet<string> { "Fruit", "Meat", "Seeds", "Vegetable" };
        private const double foodModifier = 0.35;

        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize, foods, foodModifier)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Cluck");
        }
    }
}
