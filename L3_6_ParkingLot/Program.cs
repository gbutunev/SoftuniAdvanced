using System;
using System.Collections.Generic;

namespace L3_6_ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "IN":
                        cars.Add(input[1]);
                        break;
                    case "OUT":
                        cars.Remove(input[1]);
                        break;
                }
                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (cars.Count!=0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
