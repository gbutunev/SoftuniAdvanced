using System;
using System.Collections.Generic;
using System.Text;

namespace E6_6_SpeedRacing
{
    public class Car
    {
        string Model { get; set; }
        double FuelAmount { get; set; }
        double FuelConsumptionPerKilometer { get; set; }
        double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double lpk)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = lpk;
            TravelledDistance = 0;
        }

        public void Drive(double distance)
        {
            if (FuelAmount - FuelConsumptionPerKilometer * distance < 0)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                FuelAmount -= FuelConsumptionPerKilometer * distance;
                TravelledDistance += distance;
            }
        }

        public string GetCarInfo()
        {
            return $"{Model} {FuelAmount:F2} {TravelledDistance}";
        }
    }
}
