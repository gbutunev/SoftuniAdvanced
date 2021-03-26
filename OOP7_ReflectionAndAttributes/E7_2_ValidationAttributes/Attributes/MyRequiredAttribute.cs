using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object obj)
        {
            string param = (string)obj;
            if (string.IsNullOrEmpty(param))
            {
                return false;
            }
            return true;
        }
    }
}
