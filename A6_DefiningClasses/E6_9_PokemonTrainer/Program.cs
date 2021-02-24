using System;
using System.Collections.Generic;
using System.Linq;

namespace E6_9_PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            string input = Console.ReadLine();
            while(input != "Tournament")
            {
                string[] parts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainer = parts[0];
                string pokemon = parts[1];
                string element = parts[2];
                int health = int.Parse(parts[3]);

                if (!trainers.ContainsKey(trainer))
                {
                    trainers.Add(trainer, new Trainer(trainer));
                }
                Pokemon poke = new Pokemon(pokemon, element, health);
                trainers[trainer].Pokemons.Add(poke);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while(input != "End")
            {
                foreach(var trainer in trainers.Values)
                {
                    if (trainer.Pokemons.Where(p => p.Element == input).Count() > 0)
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Pokemons.ToList())
                        {
                            pokemon.Health -= 10;
                            if (pokemon.Health <= 0)
                            {
                                trainer.Pokemons.Remove(pokemon);
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            trainers.Values.OrderByDescending(x => x.Badges).ToList().ForEach(x => Console.WriteLine(x.ToString()));

        }
    }
}
