using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace E1_2_BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cmd = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < cmd[0]; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < cmd[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (queue.Contains(cmd[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
