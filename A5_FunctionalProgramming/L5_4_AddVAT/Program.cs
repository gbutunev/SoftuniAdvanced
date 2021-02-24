using System;
using System.Collections.Generic;
using System.Linq;

namespace L5_4_AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> prices = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

            prices.ForEach(x => { Console.WriteLine($"{x*1.2:f2}"); });
        }
    }
}
