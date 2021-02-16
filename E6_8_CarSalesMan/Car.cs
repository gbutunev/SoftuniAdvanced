using System;
using System.Collections.Generic;
using System.Text;

namespace E6_8_CarSalesMan
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; } //optional
        public string Color { get; set; } //optional

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = -1;
            Color = null;
        }

        public Car(string model, Engine engine, int weight) : this(model, engine)
        {
            Weight = weight;
        }

        public Car(string model, Engine engine, string color) : this(model, engine)
        {
            Color = color;
        }

        public Car(string model, Engine engine, int weight, string color) : this(model, engine)
        {
            Weight = weight;
            Color = color;
        }

        public override string ToString()
        {
            string na = "n/a";
            string output = $"{Model}:\n" +
                $"\t{Engine.Model}:\n" +
                $"\t\tPower: {Engine.Power}\n" +
                $"\t\tDisplacement: {(Engine.Displacement == -1 ? na : Engine.Displacement.ToString())}\n" +
                $"\t\tEfficiency: {(Engine.Efficiency == null ? na : Engine.Efficiency)}\n" +
                $"\tWeight: {(Weight == -1 ? na : Weight.ToString())}\n" +
                $"\tColor: {(Color == null ? na : Color)}";

            return output;
        }
    }
}
