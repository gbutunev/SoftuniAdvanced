using System;
using System.Collections.Generic;
using System.Linq;

namespace E1_5_FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            
            Stack<int> clothes = new Stack<int>(clothesArray);

            int capacity = int.Parse(Console.ReadLine());
            int racks = 0;

            int currentLoad = 0;
            while (clothes.Count > 0)
            {
                if (currentLoad + clothes.Peek() == capacity)
                {
                    clothes.Pop();
                    racks++;
                    currentLoad = 0;
                }
                else if (currentLoad + clothes.Peek() > capacity)
                {
                    racks++;
                    currentLoad = 0;
                }
                else
                {
                    currentLoad += clothes.Pop();
                }
            }
            if (currentLoad > 0)
            {
                racks++;
            }

            Console.WriteLine(racks);
        }
    }
}
