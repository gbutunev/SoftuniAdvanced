using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            
            string type = Console.ReadLine();
            while (type != "Beast!")
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    if (int.Parse(info[1]) < 0)
                    {
                        throw new Exception();
                    }
                    switch (type)
                    {
                        case "Dog":
                            animals.Add(new Dog(info[0], int.Parse(info[1]), info[2]));
                            break;
                        case "Frog":
                            animals.Add(new Frog(info[0], int.Parse(info[1]), info[2]));
                            break;
                        case "Cat":
                            animals.Add(new Cat(info[0], int.Parse(info[1]), info[2]));
                            break;
                        case "Kitten":
                            animals.Add(new Kitten(info[0], int.Parse(info[1])));
                            break;
                        case "Tomcat":
                            animals.Add(new Tomcat(info[0], int.Parse(info[1])));
                            break;
                        default:
                            throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                }
                type = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine(animal.ProduceSound());
            }
        }
    }
}
