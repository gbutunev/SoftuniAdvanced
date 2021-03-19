using System;
using System.Collections.Generic;
using System.Text;

namespace E3_4_BorderControl
{
    class Citizen : IIdentifiable
    {
        private string id;
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get { return id; } private set { id = value; } }

        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
    }
}
