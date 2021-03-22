using System;
using System.Collections.Generic;
using System.Text;

namespace E4_1and2_Vehicles
{
    public class Bus : Vehicle
    {
        private const double acModifier = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity, acModifier)
        {
        }

        public override void Drive(double distance, bool acOn = true)
        {
            if (!acOn)
            {
                AirConModifier = 0;
                base.Drive(distance);
                AirConModifier = acModifier;
            }
            else
            {
                base.Drive(distance);
            }
        }
    }
}
