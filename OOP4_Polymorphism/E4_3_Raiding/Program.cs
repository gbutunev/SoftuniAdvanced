using System;
using System.Collections.Generic;
using System.Linq;

namespace E4_3_Raiding
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<BaseHero> heroes = new List<BaseHero>();

            while(n > 0)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                BaseHero currentHero = HeroFactory.CreateHero(type, name);
                if (currentHero == null)
                {
                    Console.WriteLine("Invalid hero!");
                    continue;
                }

                heroes.Add(currentHero);
                n--;
            }
            int bossHealth = int.Parse(Console.ReadLine());

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }

            if (heroes.Sum(x => x.Power) >= bossHealth)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
