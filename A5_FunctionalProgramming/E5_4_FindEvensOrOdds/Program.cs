using System;
using System.Collections.Generic;
using System.Linq;

namespace E5_4_FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string arg = Console.ReadLine();

            Predicate<int> check = null;
            if (arg == "even")
            {
                check = x => x % 2 == 0;
            }
            else if (arg == "odd")
            {
                check = x => x % 2 != 0;
            }

            List<int> filtered = new List<int>();
            for (int i = nums[0]; i <= nums[1]; i++)
            {
                if (check(i))
                {
                    filtered.Add(i);
                }
            }
            Console.WriteLine(String.Join(" ", filtered));

        }
    }
}
