using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace E8_4_Froggy
{
    class Lake : IEnumerable<int>
    {
        private List<int> stones;
        private int index;

        public Lake(params int[] stones)
        {
            this.stones = new List<int>(stones);
        }
        public IEnumerator<int> GetEnumerator()
        {
            bool isFinished = false;
            if (!isFinished)
            {
                for (int i = 0; i < stones.Count; i += 2)
                {
                    yield return stones[i];
                }
                isFinished = true;
            }
            //0, 1, 2, 3
            if (stones.Count % 2 == 0)
            {
                for (int i = stones.Count - 1; i >= 0; i -= 2)
                {
                    yield return stones[i];
                }
            }
            else
            {
                for (int i = stones.Count - 2; i >= 0; i -= 2)
                {
                    yield return stones[i];
                }
            }


        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
