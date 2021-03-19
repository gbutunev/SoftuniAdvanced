using System;
using System.Collections.Generic;
using System.Text;

namespace E3_5_BirthdayCelebrations
{
    public class Pet : IBirthable
    {
        private string bday;
        public string Name { get; private set; }
        public string Birthday { get { return bday; } private set { bday = value; } }

        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthday = birthdate;
        }
    }
}
