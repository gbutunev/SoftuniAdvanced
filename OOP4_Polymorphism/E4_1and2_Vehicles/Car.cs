using System;
using System.Collections.Generic;
using System.Text;

namespace E4_1and2_Vehicles
{
    class Car : Vehicle
    {
        private const double acModifier = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity, acModifier)
        {
        }
    }
}
