using System;
using System.Collections.Generic;

namespace L1_3_SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");
            Stack<string> stackInit = new Stack<string>(arr);
            Stack<string> stack = new Stack<string>(stackInit);
            int sum = 0;

            while (stack.Count > 1)
            {
                int n1 = int.Parse(stack.Pop());
                string sign = stack.Pop();
                int n2 = int.Parse(stack.Pop());

                switch (sign)
                {
                    case ("+"):
                        {
                            stack.Push((n1 + n2).ToString());
                            break;
                        }
                    case ("-"):
                        {
                            stack.Push((n1 - n2).ToString());
                            break;
                        }
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
