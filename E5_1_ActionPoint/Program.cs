using System;
using System.Linq;

namespace E5_1_ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> action = x => Console.WriteLine(x);

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(action);
        }
    }
}
