using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace E1_11_KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            int originalSize = barrelSize;
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Stack<int> locks = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).Reverse());
            int value = int.Parse(Console.ReadLine());

            int usedBullets = 0;

            while (bullets.Count > 0 && locks.Count > 0)
            {
                if (barrelSize == 0)
                {
                    barrelSize = originalSize;
                    Console.WriteLine("Reloading!");
                }
                int currentBullet = bullets.Pop();
                usedBullets++;
                barrelSize--;
                

                int currentLock = locks.Peek();

                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Pop();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
            }

            if (barrelSize == 0 && bullets.Count != 0) Console.WriteLine("Reloading!");

            if (locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${value - usedBullets * bulletPrice}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
