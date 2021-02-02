using System;
using System.Collections.Generic;

namespace E3_1_UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> unames = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                unames.Add(input);
            }

            foreach (var uname in unames)
            {
                Console.WriteLine(uname);
            }
        }
    }
}
