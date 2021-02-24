using System;
using System.Collections.Generic;
using System.Text;

namespace L6_CarManufacturer_Refactored
{
    public class Engine
    {
        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }

        public Engine(int hp, double cc)
        {
            HorsePower = hp;
            CubicCapacity = cc;
        }
    }
}
