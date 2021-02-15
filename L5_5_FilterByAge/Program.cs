using System;
using System.Collections.Generic;
using System.Linq;

namespace L5_5_FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> people = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                people.Add(input[0], int.Parse(input[1]));
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<int, bool> ageFunc = GetAgeFunc(condition, age);
            Action<KeyValuePair<string, int>> printAction = PrintAction(format);

            foreach (var person in people)
            {
                if (ageFunc(person.Value))
                {
                    printAction(person);
                }
            }
        }

        static Func<int, bool> GetAgeFunc(string condition, int age)
        {
            switch (condition)
            {
                case "younger":
                    return x => x < age;
                case "older":
                    return x => x >= age;
                default:
                    return null;
            }
        }

        static Action<KeyValuePair<string, int>> PrintAction(string format)
        {
            switch (format)
            {
                case "name":
                    return x => Console.WriteLine(x.Key);
                case "age":
                    return x => Console.WriteLine(x.Value);
                case "name age":
                    return x => Console.WriteLine($"{x.Key} - {x.Value}");
                default:
                    return null;
            }
        }
    }
}