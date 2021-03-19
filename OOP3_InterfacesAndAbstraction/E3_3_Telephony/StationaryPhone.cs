using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E3_3_Telephony
{
    public class StationaryPhone : ITelephone
    {
        public string Call(string number)
        {
            if (!number.All(char.IsDigit))
            {
                return "Invalid number!";
            }
            return $"Dialing... {number}";
        }
    }
}
