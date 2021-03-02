using System;
using System.Collections.Generic;
using System.Text;

namespace E2_3_ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public decimal Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            products = new List<Product>();
        }

        public void PurchaseProduct(Product product)
        {
            if (product.Cost <= Money)
            {
                products.Add(product);
                Money -= product.Cost;
                Console.WriteLine($"{Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
        }

        public override string ToString()
        {
            string s = "Nothing bought";
            return $"{Name} - {(products.Count == 0 ? s : string.Join(", ", products))}";
        }
    }
}
