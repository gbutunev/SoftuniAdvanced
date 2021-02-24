using System;
using System.Collections.Generic;
using System.Linq;

namespace E1_12_CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> cups = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).Reverse());
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));

            int wastedLitres = 0;

            while(cups.Count > 0 && bottles.Count > 0)
            {
                int currentCup = cups.Pop();
                while(currentCup > 0)
                {
                    int currentBottle = bottles.Pop();

                    if (currentBottle > currentCup)
                    {
                        wastedLitres += currentBottle - currentCup;
                        currentCup = 0;
                    }
                    else
                    {
                        currentCup -= currentBottle;
                    }
                }
            }

            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else if (bottles.Count == 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedLitres}");
        }
    }
}
