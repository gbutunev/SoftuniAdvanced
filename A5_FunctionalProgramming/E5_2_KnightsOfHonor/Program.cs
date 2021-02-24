using System;
using System.Linq;

namespace E5_2_KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> action = x => Console.WriteLine($"Sir {x}");

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(action);
        }
    }
}
