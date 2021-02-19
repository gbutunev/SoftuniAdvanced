using System;
using System.Collections.Generic;

namespace E8_6_EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> ssp = new SortedSet<Person>();
            HashSet<Person> hsp = new HashSet<Person>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                Person person = new Person(parts[0], int.Parse(parts[1]));
                ssp.Add(person);
                hsp.Add(person);
            }

            Console.WriteLine(ssp.Count);
            Console.WriteLine(hsp.Count);
        }
    }
}
