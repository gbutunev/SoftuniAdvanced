using System;
using System.Collections.Generic;
using System.Text;

namespace E8_1_ListyIterator
{
    class ListyIterator<T>
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
            //currentIndex++;
            //return currentIndex < list.Count;

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
    }
}
