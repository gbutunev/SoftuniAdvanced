using System;
using System.Collections.Generic;
using System.Text;

namespace E4_1and2_Vehicles
{
    class Truck : Vehicle
    {
        private const double acModifier = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity, acModifier)
        {
        }

        public override void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new InvalidOperationException("Fuel must be a positive number");
            }
            if (FuelQuantity + fuel > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {fuel} fuel in the tank");
            }
            FuelQuantity += fuel * 0.95;
        }
    }
}
