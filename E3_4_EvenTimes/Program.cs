using System;
using System.Collections.Generic;
using System.Linq;

namespace E3_4_EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int curr = int.Parse(Console.ReadLine());
                if (numbers.ContainsKey(curr))
                {
                    numbers[curr]++;
                }
                else
                {
                    numbers.Add(curr, 1);
                }
            }

            Console.WriteLine(numbers.Where(x => x.Value % 2 == 0).FirstOrDefault().Key);
        }
    }
}
