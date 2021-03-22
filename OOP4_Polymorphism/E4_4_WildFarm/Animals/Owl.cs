using System;
using System.Collections.Generic;
using System.Text;

namespace E4_4_WildFarm.Animals
{
    public class Owl : Bird
    {
        private static HashSet<string> foods = new HashSet<string> { "Meat" };
        private const double foodModifier = 0.25;
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize, foods, foodModifier)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}
