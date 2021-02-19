using System;
using System.Collections.Generic;
using System.Linq;

namespace E4_8_CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            Func<List<int>, List<int>> func = x =>
            {
                List<int> newList = new List<int>();
                x.Sort();
                foreach (var n in x.ToArray())
                {
                    if (n % 2 == 0)
                    {
                        newList.Add(n);
                        x.Remove(n);
                    }
                }
                newList.AddRange(x);
                return newList;
            };

            Console.WriteLine(string.Join(" ", func(input)));
        }
    }
}
