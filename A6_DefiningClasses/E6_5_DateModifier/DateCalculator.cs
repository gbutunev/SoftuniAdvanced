using System;
using System.Collections.Generic;
using System.Text;

namespace E6_5_DateModifier
{
    public static class DateCalculator
    {
        public static int DateDifference(string date1, string date2)
        {
            DateTime d1 = DateTime.Parse(date1);
            DateTime d2 = DateTime.Parse(date2);

            return Math.Abs((int)(d1 - d2).TotalDays);
        }
    }
}
