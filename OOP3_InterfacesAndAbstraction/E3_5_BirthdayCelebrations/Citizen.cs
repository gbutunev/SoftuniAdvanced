using System;
using System.Collections.Generic;
using System.Text;

namespace E3_5_BirthdayCelebrations
{
    class Citizen : IIdentifiable, IBirthable
    {
        private string id;
        private string bday;
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get { return id; } private set { id = value; } }
        public string Birthday { get { return bday; } private set { bday = value; } }

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthday = birthdate;
        }
    }
}
