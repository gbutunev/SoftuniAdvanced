using System;
using System.Collections.Generic;
using System.Text;

namespace L3_2_Cars
{
    public class Seat : ICar
    {
        private string model;
        private string color;
        public string Model { get { return model; } set { model = value; } }
        public string Color { get { return color; } set { color = value; } }
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{Color} Seat {Model}\n{Start()}\n{Stop()}";
        }
    }
}
