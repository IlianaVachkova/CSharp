using System.Collections;
using System.Collections.Generic;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private IList<int> stones;

        public Lake(IEnumerable<int> stones)
        {
            this.stones = new List<int>(stones);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i += 2)
            {
                yield return this.stones[i];
            }

            int lastOddPositon = 0;
            if (this.stones.Count % 2 == 0)
            {
                lastOddPositon = this.stones.Count - 1;
            }
            else
            {
                lastOddPositon = this.stones.Count - 2;
            }

            for (int i = lastOddPositon; i >= 0; i -= 2)
            {
                yield return this.stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
