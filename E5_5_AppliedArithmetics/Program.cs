using System;
using System.Collections.Generic;
using System.Linq;

namespace E5_5_AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Action<List<int>> print = list => Console.WriteLine(String.Join(" ", list));
            string cmd = Console.ReadLine();
            while(cmd != "end")
            {
                Func<int, int> operation = null;
                
                switch (cmd)
                {
                    case "add":
                        operation = x => x + 1;
                        break;
                    case "multiply":
                        operation = x => x * 2;
                        break;
                    case "subtract":
                        operation = x => x - 1;
                        break;
                    case "print":
                        print(numbers);
                        break;
                }

                if (operation != null)
                {
                    numbers = numbers.Select(operation).ToList();
                }

                cmd = Console.ReadLine();
            }
        }
    }
}
