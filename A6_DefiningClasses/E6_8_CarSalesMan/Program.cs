using System;
using System.Collections.Generic;

namespace E6_8_CarSalesMan
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //engine input
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engine = null;
                if (input.Length == 2)
                {
                    engine = new Engine(input[0], int.Parse(input[1]));
                }
                else if (input.Length == 4)
                {
                    engine = new Engine(input[0], int.Parse(input[1]), int.Parse(input[2]), input[3]);
                }
                else if (input.Length == 3)
                {
                    try
                    {
                        engine = new Engine(input[0], int.Parse(input[1]), int.Parse(input[2]));
                    }
                    catch (Exception)
                    {
                        engine = new Engine(input[0], int.Parse(input[1]), input[2]);
                    }
                }
                else
                {
                    continue;
                }

                engines.Add(input[0], engine);
            }

            int m = int.Parse(Console.ReadLine());
            //vehicle input
            List<Car> cars = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                string engineModel = input[1];

                Car car = null;
                if (input.Length == 2)
                {
                    car = new Car(model, engines[engineModel]);
                }
                else if (input.Length == 4)
                {
                    car = new Car(model, engines[engineModel], int.Parse(input[2]), input[3]);
                }
                else if (input.Length == 3)
                {
                    try
                    {
                        car = new Car(model, engines[engineModel], int.Parse(input[2]));
                    }
                    catch (Exception)
                    {
                        car = new Car(model, engines[engineModel], input[2]);
                    }
                }
                else
                {
                    continue;
                }

                cars.Add(car);
            }

            cars.ForEach(car => Console.WriteLine(car.ToString()));
        }
    }
}
