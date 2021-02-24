﻿using System;
using System.Collections.Generic;
using System.Text;

namespace L7_2_GenericArrayCreator
{
    class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            T[] array = new T[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = item;
            }

            return array;
        }
    }
}