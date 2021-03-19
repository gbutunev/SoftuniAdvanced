using System;
using System.Collections.Generic;
using System.Text;

namespace E3_6_FoodShortage
{
    public interface IBuyer
    {
        int Food { get; }
        void BuyFood();
    }
}
