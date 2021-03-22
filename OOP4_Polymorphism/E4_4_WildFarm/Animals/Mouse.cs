using System;
using System.Collections.Generic;
using System.Text;

namespace E4_4_WildFarm.Animals
{
    public class Mouse : Mammal
    {
        private static HashSet<string> foods = new HashSet<string> { "Fruit", "Vegetable" };
        private const double foodModifier = 0.1;

        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion, foods, foodModifier)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Squeak");
        }
    }
}
