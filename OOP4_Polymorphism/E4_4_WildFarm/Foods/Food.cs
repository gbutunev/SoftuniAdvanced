using System;
using System.Collections.Generic;
using System.Text;

namespace E4_4_WildFarm.Foods
{
    public abstract class Food
    {
        public int Quantity { get; private set; }
        public Food(int qty)
        {
            Quantity = qty;
        }
    }
}
