namespace E6_8_CarSalesMan
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; } //optional
        public string Efficiency { get; set; } //optional

        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
            Displacement = -1;
            Efficiency = null;
        }

        public Engine(string model, int power, int displacement) : this (model, power)
        {
            Displacement = displacement;
        }

        public Engine(string model, int power, string efficiency) : this(model, power)
        {
            Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency) : this(model, power)
        {
            Displacement = displacement;
            Efficiency = efficiency;
        }
    }
}