using System;
using System.Collections.Generic;
using System.Text;

namespace L7_1_BoxOfT
{
    class Box<T>
    {
        private Stack<T> items;

        public int Count { get { return items.Count; } }

        public Box()
        {
            items = new Stack<T>();
        }

        public void Add(T element)
        {
            items.Push(element);
        }

        public T Remove()
        {
            return items.Pop();
        }
    }
}
