using System;

namespace E4_1and2_Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] truckInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] busInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Car car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]), double.Parse(carInput[3]));
            Truck truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]), double.Parse(truckInput[3]));
            Bus bus = new Bus(double.Parse(busInput[1]), double.Parse(busInput[2]), double.Parse(busInput[3]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                double param = double.Parse(input[2]);

                switch (input[0])
                {
                    case "Drive":
                        try
                        {
                            if (input[1] == nameof(Car))
                            {
                                car.Drive(param);
                            }
                            else if (input[1] == nameof(Truck))
                            {
                                truck.Drive(param);
                            }
                            else
                            {
                                bus.Drive(param);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "Refuel":
                        try
                        {
                            if (input[1] == nameof(Car))
                            {
                                car.Refuel(param);
                            }
                            else if (input[1] == nameof(Truck))
                            {
                                truck.Refuel(param);
                            }
                            else
                            {
                                bus.Refuel(param);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "DriveEmpty":
                        try
                        {
                            bus.Drive(param, false);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}
