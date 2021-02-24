using System;
using System.Collections.Generic;
using System.Linq;

namespace L1_2_StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(arr);

            string cmd = Console.ReadLine().ToLower();
            while (cmd != "end")
            {
                if (cmd.Contains("add"))
                {
                    int a = int.Parse(cmd.Split(" ")[1]);
                    int b = int.Parse(cmd.Split(" ")[2]);

                    stack.Push(a);
                    stack.Push(b);
                }
                else if (cmd.Contains("remove"))
                {
                    int num = int.Parse(cmd.Split(" ")[1]);

                    if (num <= stack.Count)
                    {
                        for (int i = 0; i < num; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                cmd = Console.ReadLine().ToLower();
            }

            int sum = 0;

            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
