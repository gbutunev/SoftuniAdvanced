using System;
using System.Collections.Generic;
using System.Text;

namespace E7_3and4_GenericSwapMethod
{
    class Box<T>
    {
        private T item;

        public Box(T item)
        {
            this.item = item;
        }

        public override string ToString()
        {
            return $"{item.GetType()}: {item}";
        }
    }
}
