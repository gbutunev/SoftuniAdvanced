using System;
using System.Collections.Generic;
using System.Linq;

namespace E8_4_Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            Lake lake = new Lake(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

            List<int> path = new List<int>();
            foreach (var stone in lake)
            {
                path.Add(stone);
            }

            Console.WriteLine(string.Join(", ", path));
        }
    }
}
