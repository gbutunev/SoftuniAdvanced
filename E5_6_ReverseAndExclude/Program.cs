using System;
using System.Linq;

namespace E5_6_ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            Func<int, bool> check = x => x % n != 0;

            Console.WriteLine(string.Join(" ", arr.Where(check).ToArray().Reverse()));
        }
    }
}
