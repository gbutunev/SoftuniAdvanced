using System;
using System.Collections.Generic;
using System.Text;

namespace E7_7_Tuple
{
    class Tuple<T, S>
    {
        private T value1;
        private S value2;

        public Tuple(T value1, S value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        public override string ToString()
        {
            return $"{value1} -> {value2}";
        }
    }
}
