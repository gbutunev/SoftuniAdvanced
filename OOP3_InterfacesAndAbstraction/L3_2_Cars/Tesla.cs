using System;
using System.Collections.Generic;
using System.Text;

namespace L3_2_Cars
{
    class Tesla : ICar, IElectricCar
    {
        private string model;
        private string color;
        private int battery;
        public string Model { get { return model; }set { model = value; } }
        public string Color { get { return color; } set { color = value; } }
        public int Battery { get { return battery; } set { battery = value; } }

        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
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
            return $"{Color} Tesla {Model} with {Battery} Batteries\n{Start()}\n{Stop()}";
        }
    }
}
