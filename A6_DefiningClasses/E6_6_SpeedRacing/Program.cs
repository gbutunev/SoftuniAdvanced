using System;
using System.Collections.Generic;

namespace E6_6_SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                cars.Add(input[0], new Car(input[0], double.Parse(input[1]), double.Parse(input[2])));
            }

            string cmd = Console.ReadLine();
            while (cmd != "End")
            {
                string[] parts = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (parts[0] == "Drive")
                {
                    string model = parts[1];
                    double dist = double.Parse(parts[2]);

                    cars[model].Drive(dist);
                }

                cmd = Console.ReadLine();
            }

            foreach (var car in cars.Values)
            {
                Console.WriteLine(car.GetCarInfo());
            }
        }
    }
}
