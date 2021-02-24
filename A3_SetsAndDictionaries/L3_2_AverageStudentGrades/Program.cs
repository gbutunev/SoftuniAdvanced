using System;
using System.Collections.Generic;
using System.Linq;

namespace L3_2_AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> gradeBook = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                decimal grade = decimal.Parse(input[1]);

                if (!gradeBook.ContainsKey(input[0]))
                {
                    gradeBook[input[0]] = new List<decimal>();
                }

                gradeBook[input[0]].Add(grade);
            }

            foreach (var el in gradeBook)
            {
                Console.Write($"{el.Key} -> ");
                foreach (var grade in el.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {el.Value.Average():f2})");
            }
        }
    }
}
