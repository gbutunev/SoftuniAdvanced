using System;
using System.Collections.Generic;
using System.Text;

namespace E7_5and6_GenericCountMethod
{
    class Box<T> where T : IComparable<T>
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

        public bool IsLargerThan(T item)
        {
            return this.item.CompareTo(item) > 0;
        }
    }
}
