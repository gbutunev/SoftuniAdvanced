using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        public int MinValue { get; private set; }
        public int MaxValue { get; private set; }

        public MyRangeAttribute(int minValue, int maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }
        public override bool IsValid(object obj)
        {
            int param = (int)obj;

            if (param >= MinValue && param <= MaxValue)
            {
                return true;
            }
            return false;
        }
    }
}
