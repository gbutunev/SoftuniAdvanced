using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                MyValidationAttribute[] propertyAttributes = property
                    .GetCustomAttributes()
                    .Where(p => p is MyValidationAttribute)
                    .Cast<MyValidationAttribute>()
                    .ToArray();

                object value = property.GetValue(obj);

                foreach (MyValidationAttribute attribute in propertyAttributes)
                {
                    if (!attribute.IsValid(value))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
