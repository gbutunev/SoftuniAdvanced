using System;
using System.Collections.Generic;

namespace L1_6_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> people = new Queue<string>();

            string input = Console.ReadLine();
            while (input.ToLower() != "end")
            {
                if (input.ToLower() == "paid")
                {
                    while (people.Count > 0)
                    {
                        Console.WriteLine(people.Dequeue());
                    }
                }
                else
                {
                    people.Enqueue(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{people.Count} people remaining.");
        }
    }
}
