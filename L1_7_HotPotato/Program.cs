using System;
using System.Collections.Generic;

namespace L1_7_HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kidsArray = Console.ReadLine().Split(" ");
            Queue<string> kids = new Queue<string>(kidsArray);
            int tosses = int.Parse(Console.ReadLine());

            int count = 0;
            while (kids.Count > 1)
            {
                count++;
                if (count == tosses)
                {
                    count = 0;
                    Console.WriteLine($"Removed {kids.Dequeue()}");
                }
                else
                {
                    kids.Enqueue(kids.Dequeue());
                }
            }

            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
