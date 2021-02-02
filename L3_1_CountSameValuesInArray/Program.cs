using System;
using System.Collections.Generic;
using System.Linq;

namespace L3_1_CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Dictionary<double, int> dict = new Dictionary<double, int>();

            foreach (var el in input)
            {
                if (dict.ContainsKey(el))
                {
                    dict[el]++;
                }
                else
                {
                    dict[el] = 1;
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
