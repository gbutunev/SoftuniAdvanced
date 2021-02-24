using System;
using System.Collections.Generic;
using System.Text;

namespace E6_7_RawData
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }

        public Car(string model, int speed, int power, int weight, string type, double p1, double p2, double p3, double p4, int age1, int age2, int age3, int age4)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(type, weight);
            Tires = new Tire[]{ new Tire(p1, age1), new Tire(p2, age2), new Tire(p3, age3), new Tire(p4, age4)};
        }

        public void PrintModel()
        {
            Console.WriteLine(Model);
        }
    }
}
