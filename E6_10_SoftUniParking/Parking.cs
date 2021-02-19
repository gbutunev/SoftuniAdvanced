using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E6_10_SoftUniParking
{
    class Parking
    {
        private List<Car> cars;
        private int capacity;

        public int Count { get { return cars.Count; } }

        public Parking(int capacity)
        {
            cars = new List<Car>();
            this.capacity = capacity;
        }

        public string AddCar(Car Car)
        {
            if (cars.Any(x => x.RegistrationNumber == Car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if (cars.Count >= capacity)
            {
                return "Parking is full!";
            }
            cars.Add(Car);
            return $"Successfully added new car {Car.Make} {Car.RegistrationNumber}";
        }

        public string RemoveCar(string RegistrationNumber)
        {
            if (!cars.Any(x => x.RegistrationNumber == RegistrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }
            cars.Remove(cars.FirstOrDefault(x => x.RegistrationNumber == RegistrationNumber));
            return $"Successfully removed {RegistrationNumber}";
        }

        public Car GetCar(string RegistrationNumber)
        {
            return cars.Where(x => x.RegistrationNumber == RegistrationNumber).FirstOrDefault();
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var plate in RegistrationNumbers)
            {
                cars.RemoveAll(x => x.RegistrationNumber == plate);
            }
        }
    }
}
