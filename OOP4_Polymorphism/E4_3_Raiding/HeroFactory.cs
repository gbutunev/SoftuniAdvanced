using System;
using System.Collections.Generic;
using System.Text;

namespace E4_3_Raiding
{
    public static class HeroFactory
    {
        public static BaseHero CreateHero(string type, string name)
        {
            switch (type)
            {
                case nameof(Druid):
                    return new Druid(name);
                case nameof(Paladin):
                    return new Paladin(name);
                case nameof(Rogue):
                    return new Rogue(name);
                case nameof(Warrior):
                    return new Warrior(name);
                default:
                    return null;
            }
        }
    }
}
