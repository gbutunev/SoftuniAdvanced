using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace E8_3_Stack
{
    class CustomStack<T> : IEnumerable<T>
    {
        private List<T> list;
        private int currentIndex;

        public CustomStack(params T[] items)
        {
            list = new List<T>(items);
            currentIndex = list.Count - 1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                yield return list[i];
            }
        }

        public bool HasNext()
        {
            return currentIndex - 1 >= 0;
        }

        public T Pop()
        {
            if (currentIndex < 0)
            {
                throw new Exception("No elements");
            }
            else
            {
                T item = list[currentIndex];
                list.RemoveAt(currentIndex);
                currentIndex--;
                return item;
            }
        }

        public void Push(T item)
        {
            list.Add(item);
            currentIndex++;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
