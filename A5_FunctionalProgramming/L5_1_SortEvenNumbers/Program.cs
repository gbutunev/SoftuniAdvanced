﻿using System;
using System.Linq;

namespace L5_1_SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(", ", Console.ReadLine().Split(", ").Select(int.Parse).Where(x => x%2 ==0).OrderBy(x=>x)));
        }
    }
}
