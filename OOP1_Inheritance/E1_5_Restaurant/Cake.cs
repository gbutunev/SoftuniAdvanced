using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Cake : Dessert
    {
        private const decimal price = 5;
        private const int grams = 250;
        private const double calories = 1000;
        public Cake(string name) : base(name, price, grams, calories)
        {
        }
    }
}
