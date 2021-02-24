using System;
using System.Collections.Generic;
using System.Text;

namespace E7_8_Threeuple
{
    class Threeuple<T, S, U>
    {
        private T value1;
        private S value2;
        private U value3;

        public Threeuple(T value1, S value2, U value3)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }

        public override string ToString()
        {
            return $"{value1} -> {value2} -> {value3}";
        }
    }
}
