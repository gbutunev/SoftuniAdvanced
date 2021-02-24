using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace E8_6_EqualityLogic
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Person other)
        {
            if (Name.CompareTo(other.Name) == 0)
            {
                return Age.CompareTo(other.Age);
            }
            return Name.CompareTo(other.Name);
        }

        public override int GetHashCode()
        {
            return Name.Length * 1024 + Age;
        }

        public override bool Equals(object obj)
        {
            Person other = obj as Person;

            if (Name == other.Name && Age == other.Age)
            {
                return true;
            }
            return false;
        }
    }
}
