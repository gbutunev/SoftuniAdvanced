using System;
using System.Collections.Generic;
using System.Text;

namespace L2_1_Persons
{
    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public Person(string fname, string lname, int age)
        {
            FirstName = fname;
            LastName = lname;
            Age = age;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}
