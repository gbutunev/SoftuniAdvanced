using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace E1_3_MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] cmd = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                switch (cmd[0])
                {
                    case 1:
                        {
                            stack.Push(cmd[1]);
                            break;
                        }
                    case 2:
                        {
                            if (stack.Count > 0)
                            {
                                stack.Pop();
                            }
                            break;
                        }
                    case 3:
                        {
                            if (stack.Count > 0)
                            {
                                Console.WriteLine(stack.Max());
                            }
                            break;
                        }
                    case 4:
                        {
                            if (stack.Count > 0)
                            {
                                Console.WriteLine(stack.Min());
                            }
                            break;
                        }
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
