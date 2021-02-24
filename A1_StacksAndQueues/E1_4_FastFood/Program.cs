using System;
using System.Collections.Generic;
using System.Linq;

namespace E1_4_FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] orderArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(orderArray);

            Console.WriteLine(orders.Max());

            while (orders.Count > 0)
            {
                if (quantity < orders.Peek())
                {
                    Console.WriteLine($"Orders left: {String.Join(" ", orders)}");
                    break;
                }
                quantity -= orders.Dequeue();
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
