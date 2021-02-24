using System;
using System.Collections.Generic;
using System.Text;

namespace L6_CarManufacturer_Refactored
{
    public class Tire
    {
        public int Year { get; set; }
        public double Pressure { get; set; }

        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
    }
}
