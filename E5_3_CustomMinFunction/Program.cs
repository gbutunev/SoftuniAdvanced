using System;
using System.Linq;

namespace E5_3_CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> minFunc = arr =>
            {
                int min = int.MaxValue;

                foreach (var x in arr)
                {
                    if (x < min)
                    {
                        min = x;
                    }
                }

                return min;
            };

            Console.WriteLine(minFunc(nums));
        }
    }
}
