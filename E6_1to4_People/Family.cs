﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E6_1to4_People
{
    class Family
    {
        private List<Person> members = new List<Person>();

        public void AddMember(Person member)
        {
            members.Add(member);
        }

        public Person GetOldestMember()
        {
            return members.OrderByDescending(x => x.Age).First();
        }
    }
}
