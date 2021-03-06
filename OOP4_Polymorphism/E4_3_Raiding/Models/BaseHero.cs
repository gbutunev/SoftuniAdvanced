﻿using System;
using System.Collections.Generic;
using System.Text;

namespace E4_3_Raiding
{
    public abstract class BaseHero
    {
        public string Name { get; private set; }
        public int Power { get; private set; }
        public abstract string CastAbility();

        protected BaseHero(string name, int power)
        {
            Name = name;
            Power = power;
        }
    }
}
