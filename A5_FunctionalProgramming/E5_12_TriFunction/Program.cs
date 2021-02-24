using System;
using System.Collections.Generic;
using System.Linq;

namespace E5_12_TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<string, bool> predicate = x =>
            {
                int sum = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    sum += x[i];
                }
                return sum > n;
            };

            Console.WriteLine(people.First(predicate));
        }
    }
}
