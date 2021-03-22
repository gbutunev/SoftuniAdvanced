using System;
using System.Collections.Generic;
using System.Text;

namespace E4_4_WildFarm.Animals
{
    public class Tiger : Feline
    {
        private static HashSet<string> foods = new HashSet<string> { "Meat" };
        private const double foodModifier = 1.0;

        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed, foods, foodModifier)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAR!!!");
        }
    }
}
