using System;
using System.Collections.Generic;

namespace L3_5_RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> students = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                students.Add(input);
            }

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
