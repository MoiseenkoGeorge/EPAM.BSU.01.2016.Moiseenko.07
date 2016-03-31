using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Fibonachi : IEnumerable<decimal>
    {
        public IEnumerator<decimal> GetEnumerator()
        {
            decimal prevValue = 1;
            decimal currentValue = 1;
            yield return prevValue;
            yield return currentValue;
            while (true)
            {
                decimal nextValue = prevValue + currentValue;
                yield return nextValue;
                prevValue = currentValue;
                currentValue = nextValue;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
