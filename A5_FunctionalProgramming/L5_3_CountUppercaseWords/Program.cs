using System;
using System.Linq;

namespace L5_3_CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> upCheck = word => word[0] == Char.ToUpper(word[0]);

            string input = Console.ReadLine();

            Console.WriteLine(String.Join("\n", input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(upCheck)));
        }
    }
}
