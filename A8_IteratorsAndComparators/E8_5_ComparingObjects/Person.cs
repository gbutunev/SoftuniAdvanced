using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace E8_5_ComparingObjects
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public int CompareTo(Person other)
        {
            var names = Name.CompareTo(other.Name);
            var ages = Age.CompareTo(other.Age);
            var towns = Town.CompareTo(other.Town);

            if (names != 0)
            {
                return names;
            }
            if (ages != 0)
            {
                return ages;
            }
            return towns;
        }
    }
}
