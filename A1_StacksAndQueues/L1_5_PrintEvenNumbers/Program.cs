using System;
using System.Collections.Generic;
using System.Linq;

namespace L1_5_PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(numbers);
            List<int> evenNums = new List<int>();
            while (queue.Count > 0)
            {
                int current = queue.Dequeue();

                if (current % 2 == 0)
                {
                    evenNums.Add(current);
                }
            }

            Console.WriteLine(String.Join(", ", evenNums));
        }
    }
}
