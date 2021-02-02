using System;
using System.Collections.Generic;
using System.Linq;

namespace E1_1_BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cmd = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < cmd[0]; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < cmd[1]; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (stack.Contains(cmd[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.ToList().Min());
                }
            }
        }
    }
}
