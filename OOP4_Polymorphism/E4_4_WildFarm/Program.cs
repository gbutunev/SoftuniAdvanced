using E4_4_WildFarm.Animals;
using E4_4_WildFarm.Foods;
using System;
using System.Collections.Generic;

namespace E4_4_WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] animalInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Animal currentAnimal = CreateAnimal(animalInput);
                string[] foodInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Food currentFood = CreateFood(foodInput);

                currentAnimal.Eat(currentFood);

                animals.Add(currentAnimal);

                input = Console.ReadLine();
            }

            foreach(var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static Food CreateFood(string[] foodInput)
        {
            string type = foodInput[0];
            int qty = int.Parse(foodInput[1]);

            switch (type)
            {
                case nameof(Fruit):
                    return new Fruit(qty);
                case nameof(Meat):
                    return new Meat(qty);
                case nameof(Seeds):
                    return new Seeds(qty);
                case nameof(Vegetable):
                    return new Vegetable(qty);
                default:
                    return null;
            }
        }

        private static Animal CreateAnimal(string[] animalInput)
        {
            string type = animalInput[0];
            string name = animalInput[1];
            double weight = double.Parse(animalInput[2]);

            switch (type)
            {
                case nameof(Owl):
                    return new Owl(name, weight, double.Parse(animalInput[3]));
                case nameof(Hen):
                    return new Hen(name, weight, double.Parse(animalInput[3]));
                case nameof(Mouse):
                    return new Mouse(name, weight, animalInput[3]);
                case nameof(Dog):
                    return new Dog(name, weight, animalInput[3]);
                case nameof(Cat):
                    return new Cat(name, weight, animalInput[3], animalInput[4]);
                case nameof(Tiger):
                    return new Tiger(name, weight, animalInput[3], animalInput[4]);
                default:
                    return null;
            }
        }
    }
}
