using System;
using System.Linq;

namespace E5_7_PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Func<string, bool> check = word => word.Length <= n;

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(check)
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}
