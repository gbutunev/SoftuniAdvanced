using System;
using System.Collections.Generic;
using System.Linq;

namespace L6_CarManufacturer_Refactored
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tire[]> tireList = new List<Tire[]>();
            List<Engine> engineList = new List<Engine>();
            List<Car> carList = new List<Car>();

            string cmd = Console.ReadLine();
            while (cmd != "No more tires")
            {
                string[] parts = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Tire[] currentTires = new Tire[4];
                for (int i = 0; i < parts.Length / 2; i++)
                {
                    int year = int.Parse(parts[i * 2]);
                    double pressure = double.Parse(parts[i * 2 + 1]);

                    currentTires[i] = new Tire(year, pressure);
                }

                tireList.Add(currentTires);

                cmd = Console.ReadLine();
            }

            cmd = Console.ReadLine();
            while (cmd != "Engines done")
            {
                string[] parts = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int hp = int.Parse(parts[0]);
                double cc = double.Parse(parts[1]);

                engineList.Add(new Engine(hp, cc));

                cmd = Console.ReadLine();
            }

            cmd = Console.ReadLine();
            while (cmd != "Show special")
            {
                string[] parts = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string make = parts[0];
                string model = parts[1];
                int year = int.Parse(parts[2]);
                double fuelQty = double.Parse(parts[3]);
                double fuelCon = double.Parse(parts[4]);
                Engine engine = engineList[int.Parse(parts[5])];
                Tire[] tires = tireList[int.Parse(parts[6])];

                carList.Add(new Car(make, model, year, fuelQty, fuelCon, engine, tires));
                cmd = Console.ReadLine();
            }

            foreach (var car in carList)
            {
                double pressureSum = car.Tires.Select(x => x.Pressure).Sum();
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && pressureSum > 9 && pressureSum < 10)
                {
                    car.Drive(20);
                    car.PrintInfo();
                }
            }
        }
    }
}
