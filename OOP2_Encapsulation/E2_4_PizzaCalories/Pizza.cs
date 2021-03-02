using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E2_4_PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public Pizza(string name, Dough dough)
        {
            Name = name;
            this.dough = dough;
            toppings = new List<Topping>();
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count >= 10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);
        }

        public double GetTotalCalories()
        {
            return dough.Calories + toppings.Sum(x => x.Calories);
        }
    }
}
