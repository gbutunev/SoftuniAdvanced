using System;
using System.Collections.Generic;
using System.Linq;

namespace E6_1to4_People
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task3();
            //Task4();
        }

        static void Task3()
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                family.AddMember(new Person(cmd[0], int.Parse(cmd[1])));
            }

            family.GetOldestMember().PrintPerson();
        }

        static void Task4()
        {
            List<Person> people = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                people.Add(new Person(cmd[0], int.Parse(cmd[1])));
            }

            people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList().ForEach(x => x.PrintPerson2());
        }
    }
}
