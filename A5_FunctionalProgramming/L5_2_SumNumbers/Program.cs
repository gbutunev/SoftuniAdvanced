using System;
using System.Collections.Generic;
using System.Linq;

namespace L5_2_SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int count = 0;
            int sum = 0;

            nums.ForEach(x => { count++; sum += x; });

            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
    }
}
