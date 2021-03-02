using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const int ml = 50;
        private const decimal price = 3.5M;
        public double Caffeine { get; set; }
        public Coffee(string name, double caffeine) : base(name, price, ml)
        {
            Caffeine = caffeine;
        }
    }
}
    