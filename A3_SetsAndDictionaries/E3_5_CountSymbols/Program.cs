using System;
using System.Collections.Generic;

namespace E3_5_CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> chars = new SortedDictionary<char, int>();

            foreach (var el in input)
            {
                if (chars.ContainsKey(el))
                {
                    chars[el]++;
                }
                else
                {
                    chars.Add(el, 1);
                }
            }

            foreach (var el in chars)
            {
                Console.WriteLine($"{el.Key}: {el.Value} time/s");
            }
        }
    }
}
