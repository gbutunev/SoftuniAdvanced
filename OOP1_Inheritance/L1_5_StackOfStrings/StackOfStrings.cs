using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace L1_5_StackOfStrings
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return base.Count != 0;
        }

        public Stack<string> AddRange(IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                base.Push(item);
            }

            return this;
        }
    }
}
