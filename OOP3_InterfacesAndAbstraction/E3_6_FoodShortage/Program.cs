using System;
using System.Collections.Generic;
using System.Linq;

namespace E3_6_FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input.Length == 4)
                {
                    buyers.Add(input[0], new Citizen(input[0], int.Parse(input[1]), input[2], input[3]));
                }
                else if (input.Length == 3)
                {
                    buyers.Add(input[0], new Rebel(int.Parse(input[1]), input[2]));
                }
            }

            string name = Console.ReadLine();
            while (name != "End")
            {
                if (buyers.ContainsKey(name))
                {
                    buyers[name].BuyFood();
                }
                name = Console.ReadLine();
            }

            Console.WriteLine(buyers.Values.Sum(x => x.Food));

        }
    }
}
