using System;
using System.Collections.Generic;
using System.Text;

namespace E4_4_WildFarm.Animals
{
    public class Cat : Feline
    {
        private static HashSet<string> foods = new HashSet<string> { "Meat", "Vegetable" };
        private const double foodModifier = 0.3;

        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed, foods, foodModifier)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
