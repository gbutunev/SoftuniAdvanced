using System;
using System.Collections.Generic;
using System.Linq;

namespace E3_2_SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < size[0]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                set1.Add(num);
            }
            for (int i = 0; i < size[1]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                set2.Add(num);
            }

            set1.IntersectWith(set2);
            Console.WriteLine(String.Join(" ", set1));
        }
    }
}
