using System;
using System.Collections.Generic;
using System.Text;

namespace E4_4_WildFarm.Animals
{
    public class Dog : Mammal
    {
        private static HashSet<string> foods = new HashSet<string> { "Meat" };
        private const double foodModifier = 0.4;

        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion, foods, foodModifier)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
