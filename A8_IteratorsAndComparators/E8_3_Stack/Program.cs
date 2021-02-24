using System;
using System.Linq;

namespace E8_3_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Replace("Push ", "").Split(", ", StringSplitOptions.RemoveEmptyEntries);
            CustomStack<string> stack = new CustomStack<string>(items);

            string cmd = Console.ReadLine();
            while (cmd != "END")
            {
                if (cmd == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (cmd.StartsWith("Push"))
                {
                    stack.Push(cmd.Split(" ")[1]);
                }
                cmd = Console.ReadLine();
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
