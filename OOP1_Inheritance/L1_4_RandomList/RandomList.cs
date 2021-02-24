using System;
using System.Collections.Generic;
using System.Text;

namespace L1_4_RandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random r = new Random();
            int index = r.Next(0, base.Count);
            string output = base[index];
            base.RemoveAt(index);

            return output;
        }
    }
}
