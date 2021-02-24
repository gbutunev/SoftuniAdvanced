using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace E8_2_Collection

{
    class ListyIterator<T> : IEnumerable<T>
    {
        private readonly List<T> list;
        private int currentIndex;

        public ListyIterator(params T[] items)
        {
            list = new List<T>(items);
            currentIndex = 0;
        }

        public bool Move()
        {
            if (HasNext())
            {
                currentIndex++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            return currentIndex + 1 < list.Count;
        }
        public void Print()
        {
            if (currentIndex >= list.Count)
            {
                throw new Exception("Invalid Operation!");
            }
            Console.WriteLine(list[currentIndex]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
