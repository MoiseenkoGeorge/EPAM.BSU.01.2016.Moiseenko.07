using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public static class BubbleSorter<T>
    {
        public static void BubbleSort<T>(IList<T> list, Comparison<T> comparison)
        {
            for (int i = list.Count - 1; i >= 0; i--)
                for (int j = 0; j < i; j++)
                    if (comparison(list[j], list[j + 1]) > 0)
                        Swap(list[j], list[j + 1]);
        }
        private static void Swap<T>(T left,T right)
        {
            T temp = left;
            left = right;
            right = temp;
        }
    }
}
