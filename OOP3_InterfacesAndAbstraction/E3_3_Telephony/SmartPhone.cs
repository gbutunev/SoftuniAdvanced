using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E3_3_Telephony
{
    public class SmartPhone : ITelephone, IWeb
    {
        public string Browse(string site)
        {
            if (site.Any(x => char.IsDigit(x)))
            {
                return "Invalid URL!";
            }
            return $"Browsing: {site}!";
        }

        public string Call(string number)
        {
            if (!number.All(char.IsDigit))
            {
                return "Invalid number!";
            }
            return $"Calling... {number}";
        }
    }
}
