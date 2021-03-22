using System;
using System.Collections.Generic;
using System.Text;

namespace E4_1and2_Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        public double AirConModifier { get; protected set; }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            protected set
            {
                if (value > TankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }
        public double FuelConsumption { get; private set; }
        public double TankCapacity { get; private set; }

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity, double acModifier)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            AirConModifier = acModifier;
        }

        public virtual void Drive(double distance, bool acOn = true)
        {
            double fuelNeeded = (FuelConsumption + AirConModifier) * distance;

            if (fuelNeeded > FuelQuantity)
            {
                throw new InvalidOperationException($"{GetType().Name} needs refueling");
            }

            FuelQuantity -= fuelNeeded;
            Console.WriteLine($"{GetType().Name} travelled {distance} km");
        }

        public virtual void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new InvalidOperationException("Fuel must be a positive number");
            }
            if (FuelQuantity + fuel > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {fuel} fuel in the tank");
            }
            FuelQuantity += fuel;
        }
    }
}
