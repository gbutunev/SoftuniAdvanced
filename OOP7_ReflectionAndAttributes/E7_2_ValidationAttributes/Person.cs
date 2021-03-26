using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public class Person
    {
        [MyRequired]
        public string FullName { get; private set; }

        [MyRange(12, 90)]
        public int Age { get; private set; }

        public Person(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }
    }
}
