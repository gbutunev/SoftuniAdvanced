using System;
using System.Collections.Generic;
using System.Text;

namespace E6_1to4_People
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "No name";
            Age = 1;
        }

        public Person(int age) : this()
        {
            Age = age;
        }

        public Person(string name, int age) : this(age)
        {
            Name = name;
        }

        public void PrintPerson()
        {
            Console.WriteLine($"{Name} {Age}");
        }

        public void PrintPerson2()
        {
            Console.WriteLine($"{Name} - {Age}");
        }
    }
}
