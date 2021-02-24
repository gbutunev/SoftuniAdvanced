using System;
using System.Collections.Generic;
using System.Linq;

namespace E6_7_RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = cmd[0];
                int speed = int.Parse(cmd[1]);
                int power = int.Parse(cmd[2]);
                int weight = int.Parse(cmd[3]);
                string type = cmd[4];
                double p1 = double.Parse(cmd[5]);
                int age1 = int.Parse(cmd[6]);
                double p2 = double.Parse(cmd[7]);
                int age2 = int.Parse(cmd[8]);
                double p3 = double.Parse(cmd[9]);
                int age3 = int.Parse(cmd[10]);
                double p4 = double.Parse(cmd[11]);
                int age4 = int.Parse(cmd[12]);

                cars.Add(new Car(model, speed, power, weight, type, p1, p2, p3, p4, age1, age2, age3, age4));
            }

            string input = Console.ReadLine();
            switch (input)
            {
                case "fragile":
                    cars.Where(car => car.Cargo.Type == "fragile" && car.Tires.Min(tire => tire.Pressure) < 1).ToList().ForEach(x => x.PrintModel());
                    break;
                case "flamable":
                    cars.Where(car => car.Cargo.Type == "flamable" && car.Engine.Power > 250).ToList().ForEach(x => x.PrintModel());
                    break;
            }
        }
    }
}
