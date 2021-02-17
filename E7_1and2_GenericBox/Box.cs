using System;
using System.Collections.Generic;
using System.Text;

namespace E7_1and2_GenericBox
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
