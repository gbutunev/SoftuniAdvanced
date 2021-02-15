using System;
using System.Collections.Generic;
using System.Linq;

namespace E5_9_ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] testNums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            foreach(var num in testNums)
            {
                predicates.Add(x => x % num == 0);
            }

            for (int i = 1; i <= n; i++)
            {
                bool isDivisible = true;

                foreach(var pred in predicates)
                {
                    if (!pred(i))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}
